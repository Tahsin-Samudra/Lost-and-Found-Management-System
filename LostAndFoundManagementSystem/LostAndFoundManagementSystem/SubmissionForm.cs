using Guna.UI2.WinForms.Suite;
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
    public partial class SubmissionForm : Form
    {
        private string relativePath;
        private DashBoard dashB;
        private DAL dalSubmission;
        private Form prevForm;
        public SubmissionForm()
        {
            InitializeComponent();
        }
        public SubmissionForm(Form wpa)
        {
            InitializeComponent();            
            if(wpa.GetType().Name == "DashBoard")
            {
                this.prevForm = new DashBoard();
            }
            else
            {
                this.prevForm = new SubmissionHistory();
            }            
            
        }

        private void SubmissionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.prevForm.Visible = true;
            this.Dispose();
        }        

        private string AutoItemID()
        {
            string query = "SELECT MAX(ItemId) FROM Lost_Item";
            this.dalSubmission = new DAL();
            var DataTable = this.dalSubmission.ExecuteQueryTable(query);
            string maxId = DataTable.Rows[0][0].ToString();
            

            int Temp = 0;
            if(String.IsNullOrEmpty(maxId) == false)
            {
                string[] Splited = maxId.Split('-');
                Temp = Convert.ToInt32(Splited[1]);
            }
            
            return "I-" + (++Temp).ToString("d3");
        }
        private string AutoSubmissionID()
        {
            string query = "SELECT MAX(SubmissionId) FROM Submission";
            this.dalSubmission = new DAL();
            var DataTable = this.dalSubmission.ExecuteQueryTable(query);
            string maxId = DataTable.Rows[0][0].ToString();
            
            int Temp = 0;
            if (String.IsNullOrEmpty(maxId) == false)
            {
                string[] Splited = maxId.Split('-');
                Temp = Convert.ToInt32(Splited[1]);
            }
            return "S-" + (++Temp).ToString("d3");
        }

        private void infoSubmitBtn_Click(object sender, EventArgs e)
        {
            
            
            string Id = AutoItemID();
            string submissionId = AutoSubmissionID();
            this.dalSubmission = new DAL();         
            var submitAuth = this.dalSubmission.InsertItem(Id, this.gnaTxtItemName.Text.Trim(),this.relativePath, this.gna2CmbType.Text.Trim(), "False", this.gnaTxtLostPlace.Text.Trim(), this.gnatxtitemShelf.Text.Trim());
            var SubmissionAuth = this.dalSubmission.SubmitItem(submissionId, this.gnaTxtItemName.Text.Trim() ,this.relativePath, Id, this.gnaTxtSubmittedBy.Text.Trim(), DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd"));

            if (submitAuth && SubmissionAuth)
            {
                MessageBox.Show("Item Submitted Successfully!");
                
                
                this.prevForm.Visible = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Failed to submit the item. Please try again.");
            }
        }
        
        private void picSubmitBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            // Image file filter
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // PictureBox e image show korbe
                pictureBox1.ImageLocation = ofd.FileName;
                // Image fit korar jonno
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //OG File Path
                string originalfilePath = ofd.FileName;
                //unique file name generation 
                string extension = Path.GetExtension(originalfilePath);
                string newFileName = Guid.NewGuid().ToString() + extension;

                //Local Folder
                string uploadsFolder = Path.Combine(Application.StartupPath, "Uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                //Final Destination Path
                string destinationPath = Path.Combine(uploadsFolder, newFileName);
                File.Copy(originalfilePath, destinationPath);

                //shortened Relative Path
                this.relativePath = Path.Combine("Uploads", newFileName);

                
            }
        }
    }
}
