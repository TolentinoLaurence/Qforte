using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qforte
{
    public partial class QforteEmployee : Form
    {
        private bool menupanel1Expand;

        public QforteEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.TopLevel = false;
            mainpanel.Controls.Add(formHome);
            formHome.BringToFront();
            formHome.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.TopLevel = false;
            mainpanel.Controls.Add(formHome);
            formHome.BringToFront();
            formHome.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormViewProf formViewProf = new FormViewProf();
            formViewProf.TopLevel = false;
            mainpanel.Controls.Add(formViewProf);
            formViewProf.BringToFront();
            formViewProf.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FormAttendEmp form1 = new FormAttendEmp();
            form1.TopLevel = false;
            mainpanel.Controls.Add(form1);
            form1.BringToFront();
            form1.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            FormMessEmp Fmess = new FormMessEmp();
            Fmess.TopLevel = false;
            mainpanel.Controls.Add(Fmess);
            Fmess.BringToFront();
            Fmess.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLog formLog = new FormLog();
                formLog.Show();
                this.Hide();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            FormCalendar cal = new FormCalendar();
            cal.TopLevel = false;
            mainpanel.Controls.Add(cal);
            cal.BringToFront();
            cal.Show();
        }
    }
}
