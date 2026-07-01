using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;


namespace CalendarUI
{
    public partial class Calendar : Form
    {

        public static int _year;
        public static int _month;
        public Calendar()
        {
            InitializeComponent();
        }

        private void showDays(int month, int year)
        {
            this.flpDays.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            this.lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            for (int i = 0; i < week; i++) { 
                Uc_Days uc = new Uc_Days("");
                this.flpDays.Controls.Add(uc);
            }

            for(int i=1; i <= day; i++)
            {
                Uc_Days uc = new Uc_Days(i.ToString());
                this.flpDays.Controls.Add(uc);
            }


        }

        public void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}
