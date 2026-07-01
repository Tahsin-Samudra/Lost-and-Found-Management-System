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
    public partial class AddAdmin : Form
    {
        private DashBoard dashBoard;
        public AddAdmin()
        {
            InitializeComponent();
        }
        public AddAdmin(DashBoard dashBoard)
        {
            InitializeComponent();
            this.dashBoard = dashBoard;
        }

        private void AddAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.dashBoard == null || this.dashBoard.IsDisposed)
            {
                dashBoard = new DashBoard();
            }

            this.dashBoard.Show();
            this.Visible = false;
        }
    }
}
