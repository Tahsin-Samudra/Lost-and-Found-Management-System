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
    public partial class SupportTeamContactInfro : Form
    {
        public SupportTeamContactInfro()
        {
            InitializeComponent();


            //this.ControlBox = false;
            this.Text = "";
        }

        private void SupportTeamContactInfro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void SupportTeamContactInfro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Visible = false;

        }
    }
}
