using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostAndFoundManagementSystem
{
    public partial class AddReturn : Form
    {
        private DAL dalReturn;
        //private LoginForm lf;
        public AddReturn() { 
            InitializeComponent();
        }
        public AddReturn(string itemName, string itemID, string picPath)
        {
            InitializeComponent();

            this.lblItemID.Text = itemID;
            this.lblItemName.Text = itemName;
            this.gnaPcbPreview.ImageLocation = picPath;
        }
        
        private void AddReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            new DashBoard().Show();
        }

        private void AddReturn_Load(object sender, EventArgs e)
        {
            this.lblReturnOnDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblReturnTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            //Open Up a new form to store info on who is returning the item and when is it being returned! 
            //if (this.dgvShowLostItems.SelectedRows.Count < 1)
            //{
            //    MessageBox.Show("Please select an item to return.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if(this.dgvShowLostItems.CurrentRow.Cells["Status"].Value.ToString() == "Returned")
            //{
            //    MessageBox.Show("This item has already been returned.", "Item Already Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //DialogResult res = MessageBox.Show("Are you sure to remove " + this.dgvShowLostItems.CurrentRow.Cells["ItemID"].Value.ToString() + " and item type = " + this.dgvShowLostItems.CurrentRow.Cells["Type"].Value.ToString() + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if(res == DialogResult.No)
            //{
            //    return;
            //} 

            ////retreiving data table 
            //this.dalDashBoard = new DAL();
            //var itemID = this.dgvShowLostItems.CurrentRow.Cells["ItemID"].Value.ToString();
            //bool auth = this.dalDashBoard.ReturnStuff(itemID);
            ////bool auth2 = this.dalDashBoard.InsertReturnTable(AutoRetIDGenerate(), this.dgvShowLostItems.CurrentRow.Cells["ItemName"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells["Picture"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells["ItemID"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells["Returned_By"].Value.ToString(), this.dgvShowLostItems.CurrentRow.Cells[""].Value.ToString());

            //this.dalDashBoard.closeConnection();

            //if(auth)
            //{
            //    MessageBox.Show("Returned!");
            //    PopulateGridView();

            //}
            //else
            //{
            //    MessageBox.Show("Error !");
            //}
            this.dalReturn = new DAL();
            string retID = this.AutoRetIDGenerate();
            //lf = new LoginForm();
            //lf initiate
            var returned = this.dalReturn.InsertReturnTable(retID, this.txtReturn.Text.Trim(),this.gnaPcbPreview.ImageLocation,this.lblItemID.Text.Trim(), LoginForm.UserID, this.lblReturnTime.Text, this.lblReturnOnDate.Text);
            if(returned)
            {
                MessageBox.Show("Item Returned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Failed to Return Item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string AutoRetIDGenerate()
        {
            string query = "SELECT MAX(ReturnID) FROM TReturn";
            this.dalReturn = new DAL();
            var DataTable = this.dalReturn.ExecuteQueryTable(query);
            string maxId = DataTable.Rows[0][0].ToString();


            int Temp = 0;
            if (String.IsNullOrEmpty(maxId) == false)
            {
                string[] Splited = maxId.Split('-');
                Temp = Convert.ToInt32(Splited[1]);
            }

            return "R-" + (++Temp).ToString("d3");
        }


    }
}
