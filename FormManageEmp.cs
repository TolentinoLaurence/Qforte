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
    public partial class FormManageEmp : Form
    {
        public FormManageEmp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data source=.;initial catalog=Qforte_DB;integrated security=true");

        private void FormManageEmp_Load(object sender, EventArgs e)
        {
            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select Employee_ID,Employee_name As Emp_name,Employee_age As Emp_age,Employee_gender As Emp_gender,Employee_position As Emp_position,Employee_contact As Emp_contact,Employee_address As Emp_address,Employee_bod As Emp_bod,Employee_password As Emp_password", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into a Employee(Employee_ID,Employee_name,Employee_age,Employee_gender,Employee_position,Employee_contact,Employee_address,Employee_bod,Employee_password)Values(@Employee_ID,@Emp_name,@Emp_age,@Emp_gender,@Emp_position,@Emp_contact,@Emp_address,@Emp_bod,@Emp_password)", conn);
            cmd2.Parameters.AddWithValue("Emp_ID", txtemployee_ID.Text);
            cmd2.Parameters.AddWithValue("Emp_name", txtemployee_name.Text);
            cmd2.Parameters.AddWithValue("Emp_age", txtage.Text);
            cmd2.Parameters.AddWithValue("Emp_gender", txtgender.Text);
            cmd2.Parameters.AddWithValue("Emp_position", txtposition.Text);
            cmd2.Parameters.AddWithValue("Emp_contact", txtcontact.Text);
            cmd2.Parameters.AddWithValue("Emp_ID", txtaddress.Text);
            cmd2.Parameters.AddWithValue("Emp_ID", txtbod.Text);
            cmd2.Parameters.AddWithValue("Emp_ID", txtpassword.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtemployee_ID.Text = "";
            txtemployee_name.Text = "";
            txtage.Text = "";
            txtgender.Text = "";
            txtposition.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtpassword.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtemployee_ID.Text = selectedrow.Cells[0].Value.ToString();
            txtemployee_name.Text = selectedrow.Cells[1].Value.ToString();
            txtage.Text = selectedrow.Cells[2].Value.ToString();
            txtgender.Text = selectedrow.Cells[3].Value.ToString();
            txtposition.Text = selectedrow.Cells[4].Value.ToString();
            txtaddress.Text = selectedrow.Cells[5].Value.ToString();
            txtbod.Text = selectedrow.Cells[6].Value.ToString();
            txtpassword.Text = selectedrow.Cells[7].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Employee Set(Emp_ID-@Employee_ID,Emp_name-@Employee_name,Emp_age-@Employee_age,Emp_gender-@Employee_gender,Emp_contact-@Employee_contact,Emp_address-@Employee_address,Emp_bod-@Employee_bod,Employee_password-@Employee_password)", conn);
            cmd3.Parameters.AddWithValue("Emp_ID", txtemployee_ID.Text);
            cmd3.Parameters.AddWithValue("Emp_name", txtemployee_name.Text);
            cmd3.Parameters.AddWithValue("Emp_age", txtage.Text);
            cmd3.Parameters.AddWithValue("Emp_gender", txtgender.Text);
            cmd3.Parameters.AddWithValue("Emp_position", txtposition.Text);
            cmd3.Parameters.AddWithValue("Emp_contact", txtcontact);
            cmd3.Parameters.AddWithValue("Emp_address", txtaddress.Text);
            cmd3.Parameters.AddWithValue("Emp_bod", txtbod.Text);
            cmd3.Parameters.AddWithValue("Emp_password", txtpassword.Text);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from Employee where EmployeeID-@Employee_ID", conn);
            cmd4.Parameters.AddWithValue("Employee_ID", txtemployee_ID.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }
    }
}
