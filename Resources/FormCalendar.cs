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

namespace Qforte.Resources
{
    public partial class FormCalendar : Form
    {
        public static int _year,_month;
        public FormCalendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
           _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            label8.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < week; i++)
            {
                UserControl1 uc1 = new UserControl1(i + " ");
                flowLayoutPanel1.Controls.Add(uc1);
            }
            for (int i = 1; i < day; i++)
            {
                UserControl1 uc1 = new UserControl1(" ");
                flowLayoutPanel1.Controls.Add(uc1);


            }

        }
    }

}
