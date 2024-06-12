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
            SqlCommand cmd1 = new SqlCommand("Select Attendance_ID As Attendance_ID, ID As ID, Name As Name, Position As Position, Time_In As Time_In, Time_Out As Time_Out, Date As Date from Attendance", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maxIdQuery = "SELECT MAX(Attendance_ID) FROM Attendance";
            SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, conn);

            conn.Open();
            object result = getMaxIdCmd.ExecuteScalar();
            conn.Close();

            int nextNumericPart = 1;

            if (result != DBNull.Value)
            {
                if (result is int)
                {
                    nextNumericPart = (int)result + 1;
                }
                else if (result is string)
                {
                    string maxId = (string)result;
                    int numericPart;
                    if (int.TryParse(maxId.Substring(100), out numericPart))
                    {
                        nextNumericPart = numericPart + 1;
                    }
                }
            }

            string nextId = $"ATTND{nextNumericPart:D7}";
            SqlCommand cmd = new SqlCommand("Insert into Attendance(Attendance_ID,ID, Name, Position, Time_In, Time_Out, Date) Values(@Attendance_ID,@ID, @Name, @Position, @Time_In, @Time_Out, @Date)", conn);
            cmd.Parameters.AddWithValue("Attendance_ID", nextId);
            cmd.Parameters.AddWithValue("@ID", txtEmployee_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
            cmd.Parameters.AddWithValue("@Time_In", dateTimePicker1.Value.ToString("hh:mm tt"));
            cmd.Parameters.AddWithValue("@Time_Out", dateTimePicker2.Value.ToString("hh:mm tt"));
            cmd.Parameters.AddWithValue("@Date", dateTimePicker3.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Attendance submitted successfully");
            conn.Close();
            bind_data();
        }

        private void fetchdata()
        {
            conn.Open();
            string query = "select * from Employee";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtEmployee_ID.Text = dr["ID"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtPosition.Text = dr["Position"].ToString();
                txtEmployee_ID.Visible = true;
                txtName.Visible = true;
                txtPosition.Visible = true;
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bind_data();
            fetchdata();
        }

    }
}
