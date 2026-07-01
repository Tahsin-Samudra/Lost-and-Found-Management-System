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
    public partial class SignUp : Form
    {
        private DAL dalsignup;
        private LoginForm loginForm;
        public SignUp()
        {
            InitializeComponent();
            this.Text = "";

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //INSERTION 
            //AutoIdGenrate
        public string AutoIDGenerate(string role)
        {
            string prefix;

            if (role == "Admin")
                prefix = "A-";
            else
                prefix = "S-";

            string query = $"select max(Id) from Login where Id like '{prefix}%'";

            var dataTable = this.dalsignup.ExecuteQueryTable(query);

            string oldId = dataTable.Rows[0][0].ToString();

            int temp = 0;

            if (!string.IsNullOrEmpty(oldId))
            {
                string[] splited = oldId.Split('-');
                temp = Convert.ToInt32(splited[1]);
            }

            return prefix + (++temp).ToString("D3");
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //ConfirmSubmission

            string name = this.txtName.Text.Trim();
            string pass = this.txtCreatePassword.Text.Trim();
            string role = "Student";
            string phoneNumber = this.txtPhoneNumber.Text.Trim();

            this.dalsignup = new DAL();
            string id;            
            id = AutoIDGenerate("Student");
            
            bool inserted = this.dalsignup.InsertUser(id, pass, name, role, phoneNumber);

            this.dalsignup.closeConnection();

            if (inserted) {
                MessageBox.Show("User Inserted");
            }
            else
            {
                MessageBox.Show("User error");
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(this.loginForm == null || this.loginForm.IsDisposed)
            {
                loginForm = new LoginForm();
            }

            this.loginForm.Show();
            this.Visible = false;
        }

        
    }
}
