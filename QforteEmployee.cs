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

        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebartransmission1.Start();
        }

        private void sidebartransmission1_Tick(object sender, EventArgs e)
        {
            if (menupanel1Expand)
            {
                menupanel1.Width -= 10;
                if (menupanel1.Width <= 66)
                {
                    menupanel1Expand = false;
                    sidebartransmission1.Stop();
                }
                else
                {
                    menupanel1.Width += 10;
                    if (menupanel1.Width >= 183)
                    {
                        menupanel1Expand = false;
                        sidebartransmission1.Stop();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormViewProf formViewProf = new FormViewProf();
            formViewProf.TopLevel = false;
            mainpanel.Controls.Add(formViewProf);
            formViewProf.BringToFront();
            formViewProf.Show();
        }
    }
}
