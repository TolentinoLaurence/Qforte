using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qforte.Resources
{
    public partial class UserControl1 : UserControl
    {
        string _day,date,weekdays;


        public UserControl1(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
            checkBox1.Hide();
            date = Form1._month + "/" + _day + "/" + Form1._year;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        public void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekdays = day.ToString("ddd");
                if (weekdays == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }

            }
            catch (Exception)
            {

            }

        }


        private void UserControl1Days_Load(object sender, EventArgs e)
        {
            sundays();
        }


 
    }
}
