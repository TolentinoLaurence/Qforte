using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qforte
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
            QforteAdmin qforte;
            QforteEmployee qforteEmployee;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            } else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user, password;
            user = txtUser_ID.Text;
            password = txtpassword.Text;

            if (user == "admin" && password == "admin")
            {
                MessageBox.Show("Successfully Log In");
                QforteAdmin qforte = new QforteAdmin();
                qforte.Show();
                this.Hide();
            }
            else if (user == "emp" && password == "emp")
            {
                MessageBox.Show("Successfully Log In");
                QforteEmployee qforteemp = new QforteEmployee();
                qforteemp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }
    }
}
