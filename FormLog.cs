﻿using System;
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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");


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

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application","Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user, password;
            user = txtUser_ID.Text;
            password = txtpassword.Text;

            try
            {
                string query = "Select * from Employee where ID = '" + txtUser_ID.Text + "' and Password = '" + txtpassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    user = txtUser_ID.Text;
                    password = txtpassword.Text;

                    QforteEmployee qforteEmployee = new QforteEmployee();
                    qforteEmployee.Show();
                    this.Hide();
                }
                else if (user == "admin" && password == "admin123")
                {
                    QforteAdmin qforteAdmin = new QforteAdmin();
                    qforteAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Details");
                    txtUser_ID.Clear();
                    txtpassword.Clear();
                    txtUser_ID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
