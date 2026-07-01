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
    public partial class SubmissionHistory : Form
    {
        private DAL dalSubmissionHistory;
        private DashBoard dashBoard;
        private SubmissionForm submissionForm;
        
        public SubmissionHistory()
        {
            InitializeComponent();
        }
        public SubmissionHistory(DashBoard dashBoard)
        {
            InitializeComponent();
            this.dashBoard = dashBoard;
        }

        private void SubmissionHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(this.dashBoard == null || this.dashBoard.IsDisposed)
            {
                this.dashBoard = new DashBoard();
            }

            this.dashBoard.Show();
            this.Visible = false;
        }
        private void PopulateGridView(string query = "Select * From Submission")
        {
            this.dalSubmissionHistory = new DAL();
            var dt = this.dalSubmissionHistory.ExecuteQueryTable(query);

            this.gnaDgvSubGrid.AutoGenerateColumns = false;
            this.gnaDgvSubGrid.DataSource = dt;
            
        }

        private void SubmissionHistory_Load(object sender, EventArgs e)
        {
            PopulateGridView();   
        }

        private void gnaDgvSubGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gnaDgvSubGrid.Columns[e.ColumnIndex].Name == "Picture")
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

        private void gnaBtnCreateLostItem_Click(object sender, EventArgs e)
        {
            this.submissionForm = new SubmissionForm(this);
            this.submissionForm.Visible = true;
            this.Visible = false;
        }

        private void gnaDgvSubGrid_Click(object sender, EventArgs e)
        {
            //this.lblSubmiitedby.Text = this.gnaDgvSubGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void gnaBtnUpdateSubmission_Click(object sender, EventArgs e)
        {
            if(this.gnaDgvSubGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a submission to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var x = new SubmissionUpdate(this.gnaDgvSubGrid.CurrentRow.Cells["SubmissionID"].Value.ToString(), this.gnaDgvSubGrid.CurrentRow.Cells["ItemName"].Value.ToString(), this.gnaDgvSubGrid.CurrentRow.Cells["Submitted_By"].Value.ToString(), this.gnaDgvSubGrid.CurrentRow.Cells["SubmissionTime"].Value.ToString(), this.gnaDgvSubGrid.CurrentRow.Cells["SubmittedOn"].Value.ToString(), this.gnaDgvSubGrid.CurrentRow.Cells["Picture"].Value.ToString());
            x.Show();
            this.Hide();
        }

        private void gnaBtnDelete_Click(object sender, EventArgs e)
        {
            //D E L E T E
            try
            {
                if (this.gnaDgvSubGrid.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a submission to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ItemName = this.gnaDgvSubGrid.CurrentRow.Cells["ItemName"].Value.ToString();
                var submissionID = this.gnaDgvSubGrid.CurrentRow.Cells["SubmissionID"].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + ItemName + " and SubId = " + submissionID + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "Delete From Submission Where SubmissionID = '" + submissionID + "';";
                this.dalSubmissionHistory = new DAL();
                var cnt = this.dalSubmissionHistory.ExecuteDMLQuery(sql);

                this.dalSubmissionHistory.closeConnection();
                if (cnt == 1)
                {
                    MessageBox.Show("Submission removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateGridView();
                }
                else
                    MessageBox.Show("Failed to remove the submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
