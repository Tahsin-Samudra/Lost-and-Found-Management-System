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

namespace CalendarUI
{
    public partial class Uc_Days : UserControl
    {
        private bool checkBox = false;
        private string day;        
        private string weekday;
        public Uc_Days(string day)
        {
            InitializeComponent();
            this.day = day;
            if (day.Length == 1)
            {
                this.day = "0" + day;
            }            
            
            this.lblShowDay.Text = this.day;

        }

        private void gnaPnlUcDay_Click(object sender, EventArgs e)
        {
            if (checkBox == false) { 
                this.checkBox = true;
                this.gnaPnlUcDay.FillColor = Color.Black;
                this.lblShowDay.ForeColor = Color.White;
            }
            else
            {
                this.checkBox = false;
                this.gnaPnlUcDay.FillColor = Color.Transparent;
                this.lblShowDay.ForeColor = Color.Black;
            }
        }

        private void lblShowDay_Click(object sender, EventArgs e)
        {
            if (checkBox == false)
            {
                this.checkBox = true;
                this.gnaPnlUcDay.FillColor = Color.Black;
                this.lblShowDay.ForeColor = Color.White;
            }
            else
            {
                this.checkBox = false;
                this.gnaPnlUcDay.FillColor = Color.Transparent;
                this.lblShowDay.ForeColor = Color.Black;
            }
        }
    }
}
