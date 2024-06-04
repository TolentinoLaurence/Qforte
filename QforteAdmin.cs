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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Paint += MainForm_Paint;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw a custom border
            using (Pen borderPen = new Pen(Color.DarkSlateBlue)) // Change color and thickness here
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

            private void btManage_Click(object sender, EventArgs e)
        {
            FormManageEmp formManageEmp = new FormManageEmp();
            formManageEmp.TopLevel = false;
            mainpanel.Controls.Add(formManageEmp);
            formManageEmp.BringToFront();
            formManageEmp.Show();
        }
        private void btViewEmp_Click(object sender, EventArgs e)
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

        private void btRequest_Click(object sender, EventArgs e)
        {
            FormMess mess = new FormMess();
            mess.TopLevel = false;
            mainpanel.Controls.Add(mess);
            mess.BringToFront();
            mess.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormHome formhome = new FormHome();
            formhome.TopLevel = false;
            mainpanel.Controls.Add(formhome);
            formhome.BringToFront();
            formhome.Show();

        }


        private void btCal_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.TopLevel = false;
            mainpanel.Controls.Add(calendar);
            calendar.BringToFront();
            calendar.Show();
        }
    }
}
