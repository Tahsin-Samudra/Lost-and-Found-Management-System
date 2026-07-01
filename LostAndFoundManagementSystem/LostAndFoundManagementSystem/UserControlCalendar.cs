using CalendarUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostAndFoundManagementSystem
{
    public partial class UserControlCalendar : UserControl
    {
        public static int _year;
        public static int _month;
        public UserControlCalendar()
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
            for (int i = 0; i < week; i++)
            {
                Uc_Days uc = new Uc_Days("");
                this.flpDays.Controls.Add(uc);
            }

            for (int i = 1; i <= day; i++)
            {
                Uc_Days uc = new Uc_Days(i.ToString());
                this.flpDays.Controls.Add(uc);
            }


        }

        private void UserControlCalendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void pbxForwardBtn_Click(object sender, EventArgs e)
        {
            _month++;
            if (_month > 12)
            {
                _month = 1;
                _year++;
            }
            showDays(_month, _year);
        }

        private void pbxBackwardBtn_Click(object sender, EventArgs e)
        {
            _month--;
            if (_month < 1) { 
                _month = 12;
                _year--;
            }
            showDays(_month, _year);
        }
    }
}
