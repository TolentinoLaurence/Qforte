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
    public partial class QforteAdmin : Form
    {
        public QforteAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btManageEmployee_Click(object sender, EventArgs e)
        {
            FormManageEmp formManageEmp = new FormManageEmp();
            formManageEmp.TopLevel = false;
            mainpanel.Controls.Add(formManageEmp);
            formManageEmp.BringToFront();
            formManageEmp.Show();

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btViewEmployee_Click(object sender, EventArgs e)
        {
            FormViewEmp formViewEmp = new FormViewEmp();
            formViewEmp.TopLevel = false;
            mainpanel.Controls.Add(formViewEmp);
            formViewEmp.BringToFront();
            formViewEmp.Show();
        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            FormSal formSal = new FormSal();
            formSal.TopLevel = false;
            mainpanel.Controls.Add(formSal);
            formSal.BringToFront();
            formSal.Show();
        }

        private void btAttendance_Click(object sender, EventArgs e)
        {
            FormAttend formAttend = new FormAttend();
            formAttend.TopLevel = false;
            mainpanel.Controls.Add(formAttend);
            formAttend.BringToFront();
            formAttend.Show();
        }
    }
}
