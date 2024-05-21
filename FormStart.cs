using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Qforte
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            FormLog formLog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = GetRoundedImagePictureBox(pictureBox1);
        }
        private Region GetRoundedImagePictureBox(PictureBox pictureBox)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0,0, pictureBox.Width, pictureBox.Height);
            Region rgn = new Region(graphicsPath);
            return rgn;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 5;
            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FormLog formlog = new FormLog();
                formlog.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
