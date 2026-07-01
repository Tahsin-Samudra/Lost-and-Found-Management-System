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
    public partial class SubmissionUpdate : Form
    {
        private string relativeImagePath;
        private DAL dalUpdateSub;
        public SubmissionUpdate()
        {
            InitializeComponent();
        }

        public SubmissionUpdate(string subId, string itemName, string SubmittedBy, string submissionTime, string date, string imagePath)
        {
            InitializeComponent();
            
            this.lblSubId.Text = subId;
            this.gnaTxtSubItem.Text = itemName;
            this.gnaTxtSubmitBy.Text = SubmittedBy;
            this.lblShowSubmissionDay.Text = date;
            this.lblShowSubmittedTime.Text = submissionTime;
            this.pcbPreview.ImageLocation = imagePath;
            this.relativeImagePath = imagePath; 
        }

        private void gnaBtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pcbPreview.ImageLocation = ofd.FileName;
                
                string originalFilePath = ofd.FileName;
                string extension = Path.GetExtension(originalFilePath);
                string newFilePath = Guid.NewGuid().ToString() + extension;

                string Uploads = Path.Combine(Application.StartupPath, "Uploads");
                if(!Directory.Exists(Uploads))
                {
                    Directory.CreateDirectory(Uploads);
                }
                string destinationPath = Path.Combine(Uploads, newFilePath);
                File.Copy(originalFilePath, destinationPath);

                this.relativeImagePath = Path.Combine("Uploads", newFilePath);
            }
        }

        private void gnaBtnUpdate_Click(object sender, EventArgs e)
        {
            this.dalUpdateSub = new DAL();
            try
            {
                this.dalUpdateSub.UpdateSubmissionHistory(
                    this.lblSubId.Text,
                    this.gnaTxtSubItem.Text,
                    this.relativeImagePath,
                    this.gnaTxtSubmitBy.Text,
                    this.lblShowSubmittedTime.Text,
                    this.lblShowSubmissionDay.Text
                );
                
                MessageBox.Show("Submission updated successfully!");
                this.dalUpdateSub.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void SubmissionUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            new SubmissionHistory().Show();
            this.Dispose();
        }

        private void gnaBtnCancel_Click(object sender, EventArgs e)
        {
            new SubmissionHistory().Show();
            this.Dispose();
        }
    }
}
