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

        private void menu_Click(object sender, EventArgs e)
        {
            sidebartransmission.Start();
        }
        Boolean menupanelExpand = true;

        private void sidebartransmission_Tick(object sender, EventArgs e)
        {
            if (menupanelExpand)
            {
                menupanel.Width -= 10;
                if (menupanel.Width <= 66)
                {
                    menupanelExpand = false;
                    sidebartransmission.Stop();
                }
                else
                {
                    menupanel.Width += 10;
                    if (menupanel.Width >= 183)
                    {
                        menupanelExpand = true;
                        sidebartransmission.Stop();
                    }
                }
            }
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
    }
}
