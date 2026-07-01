using CalendarUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LostAndFoundManagementSystem
{
    public partial class DashBoard : Form
    {
        private LoginForm loginPage;
        private DAL dalDashBoard;
        private AddAdmin addAdminPage;
        private bool sidebarExpand = false;
        private SubmissionHistory submissionHistoryPage;
        //private string itemIdFetched;

        public DashBoard()
        {
            InitializeComponent();
            LoadControl(new UserControlCalendar());
            PopulateGridView();
        }
        public DashBoard(LoginForm login)
        {
            InitializeComponent();

            LoadControl(new UserControlCalendar());
            PopulateGridView();
            this.loginPage = login;
        }

        public void PopulateGridView(string sql = "Select * From Lost_Item;")
        {
            this.dalDashBoard = new DAL();
            var dt = this.dalDashBoard.ExecuteQueryTable(sql);

            this.dalDashBoard.closeConnection();

            this.dgvShowLostItems.AutoGenerateColumns = false;
            this.dgvShowLostItems.DataSource = dt;
            

            this.dgvShowLostItems.EnableHeadersVisualStyles = false;
            this.dgvShowLostItems.ColumnHeadersVisible = true;
            //DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            //imgCol.Name = "Picture";
            //imgCol.HeaderText = "Image";
            //imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //dgvShowLostItems.Columns.Add(imgCol);


        }


        public void LoadControl(UserControl control)
        {            
            control.Dock = DockStyle.Fill;
            this.pnlUCCalendarLoader.Controls.Clear();
            this.pnlUCCalendarLoader.Controls.Add(control);
        }
        /*
            public void LoadControl(UserControl control)
            {
                panelContainer.Controls.Clear();

                control.Dock = DockStyle.Fill;

                panelContainer.Controls.Add(control);
            }         
        */
        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void sidebarUpDown_Tick(object sender, EventArgs e)
        {
            if(this.sidebarExpand == false)
            {
                this.pnlDashBoard.Width += 20;
                if(this.pnlDashBoard.Width >= 300)
                {
                    this.sidebarUpDown.Stop();
                    this.sidebarExpand = true;
                    
                }
            }
            else //this.sidebarExpand == true
            {
                this.pnlDashBoard.Width -= 20;
                if(this.pnlDashBoard.Width <= 70)
                {
                    this.sidebarUpDown.Stop();
                    this.sidebarExpand = false;
                    
                }
            }
        }

        
        private void gnaPnlSubmitBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SubmissionForm(this).Show();
        }
        
        private void dgvShowLostItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvShowLostItems.Columns[e.ColumnIndex].Name == "Picture")
            {
                string path = e.Value?.ToString();

                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    e.Value = Image.FromFile(path);
                }
                else
                {
                    e.Value = null; // or default image
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }

        private void pbxDashMenu_Click(object sender, EventArgs e)
        {
            sidebarUpDown.Start();
        }

        private void gnaAddAdmin_Click(object sender, EventArgs e)
        {
            this.addAdminPage = new AddAdmin(this);
            this.addAdminPage.Show();
            this.Visible = false;
        }

        private void gnaSubmissionHistory_Click(object sender, EventArgs e)
        {
            this.submissionHistoryPage = new SubmissionHistory(this);
            this.submissionHistoryPage.Show();
            this.Visible = false;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private string AutoRetIDGenerate()
        {
            string query = "SELECT MAX(ItemId) FROM Lost_Item";
            this.dalDashBoard = new DAL();
            var DataTable = this.dalDashBoard.ExecuteQueryTable(query);
            string maxId = DataTable.Rows[0][0].ToString();


            int Temp = 0;
            if (String.IsNullOrEmpty(maxId) == false)
            {
                string[] Splited = maxId.Split('-');
                Temp = Convert.ToInt32(Splited[1]);
            }

            return "R-" + (++Temp).ToString("d3");
        }
        private void gnaPnlReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddReturn(this.dgvShowLostItems.CurrentRow.Cells["ItemName"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells["ItemID"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells["Picture"].Value.ToString()).Show();
                        
        }

        private void gnaBtnReturnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReturnHistory().Show();
        }
    }
}
