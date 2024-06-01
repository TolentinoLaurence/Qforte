using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qforte
{
    public partial class FormAttendEmp : Form
    {
        public FormAttendEmp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Position As Position,Time_In As Time_In,Time_Out As Time_Out,Date As Date from Attendance", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Attendance(ID,Name,Position,Time_In,Time_Out,Date)Values(@ID,@Name,@Position,@Time_In,@Time_Out,@Date)",conn);
            cmd.Parameters.AddWithValue("ID", txtEmployee_ID.Text);
            cmd.Parameters.AddWithValue("Name", txtName.Text);
            cmd.Parameters.AddWithValue("Position", txtPosition.Text);
            cmd.Parameters.AddWithValue("Time_In", txtTime_In.Text);
            cmd.Parameters.AddWithValue("Time_Out", txtTime_Out.Text);
            cmd.Parameters.AddWithValue("Date", txtDate.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered");
            conn.Close();
            bind_data();

            MessageBox.Show("Your request has been sumbmited successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}
