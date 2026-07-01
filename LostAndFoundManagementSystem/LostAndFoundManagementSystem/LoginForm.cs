using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostAndFoundManagementSystem
{
    public partial class LoginForm : Form
    {
        private DAL dalLogin;
        private DashBoard dashBoard;
        private SupportTeamContactInfro support;
        private SignUp signUp;
        public static string adminID;

        public static string UserID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "";            
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(this.txtUsername.Text == "   Username")
            {
                this.txtUsername.Text = "";
                this.txtUsername.ForeColor = Color.Black;
            }
        }
        //Default Text UserName =   Username
        //Default Text Password =  Password
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {
                this.txtUsername.Text = "   Username";
                this.txtUsername.ForeColor = Color.Gray;
            }
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "  Password")
            {
                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.Text = "  Password";
                this.txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnClosedPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0') {
                this.btnOpenPassword.BringToFront();
                this.txtPassword.PasswordChar = '*';
            }
        }

        private void btnOpenPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                this.btnClosedPass.BringToFront();
                this.txtPassword.PasswordChar = '\0';
            }
        }

        private void lblContactInfo_Click(object sender, EventArgs e)
        {
            
            if (this.support == null || this.support.IsDisposed)
            {
                this.support = new SupportTeamContactInfro();
            }
            this.support.Show();
            this.Visible = false; 

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = this.txtUsername.Text;
            string pass = this.txtPassword.Text;
            //DataBase Access
            this.dalLogin = new DAL();
            int authentication = this.dalLogin.Validity(id, pass);
            
            this.dalLogin.closeConnection();
            

            if (authentication == 1) {
                UserID = id;
                MessageBox.Show("Login Successful");
                
                this.dashBoard = new DashBoard(this);
                this.dashBoard.Visible = true;
                this.Visible = false;           
            }
            else
            {
                MessageBox.Show("Login Denied");
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //NEw form
            if (this.signUp == null || this.signUp.IsDisposed)
            {
                this.signUp = new SignUp();                
            }
            this.signUp.Show();
            this.Visible = false;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
