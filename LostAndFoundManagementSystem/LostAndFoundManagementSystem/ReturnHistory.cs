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
    public partial class ReturnHistory : Form
    {
        private DAL dalLostItemShow;
        public ReturnHistory()
        {
            InitializeComponent();
            PopulateGridView();
        }

        public void PopulateGridView(string sql = "Select * From TReturn;") {
            this.dalLostItemShow = new DAL();
            var dt = this.dalLostItemShow.ExecuteQueryTable(sql);

            this.dalLostItemShow.closeConnection();
            this.gnaDgvReturnTable.AutoGenerateColumns = false;
            this.gnaDgvReturnTable.DataSource = dt;

            this.gnaDgvReturnTable.EnableHeadersVisualStyles = false;
            this.gnaDgvReturnTable.ColumnHeadersVisible = true;
        }

        private void ReturnPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            new DashBoard().Show();
        }

        

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            new AddReturn().Show();
            this.Hide();
        }

        private void gnaDgvReturnTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.gnaDgvReturnTable.Columns[e.ColumnIndex].Name == "Picture")
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
    }
}
