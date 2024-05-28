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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        private void FormManageEmp_Load(object sender, EventArgs e)
        {
            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Age As Age,Gender As Gender,Position As Position,Contact As Contact,Address As Address,BOD As BoD,Password As Password from Employee", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into Employee(Id,Name,Age,Gender,Position,Contact,Address,BoD,Password)Values(@Id,@Name,@Age,@Gender,@Position,@Contact,@Address,@BoD,@Password)", conn);
            cmd2.Parameters.AddWithValue("ID", txtemployee_ID.Text);
            cmd2.Parameters.AddWithValue("Name", txtemployee_name.Text);
            cmd2.Parameters.AddWithValue("Age", int.Parse(txtage.Text));
            cmd2.Parameters.AddWithValue("Gender", cbGender.Text);
            cmd2.Parameters.AddWithValue("Position", cbPosition.Text);
            cmd2.Parameters.AddWithValue("Contact", float.Parse(txtcontact.Text));
            cmd2.Parameters.AddWithValue("Address", txtaddress.Text);
            cmd2.Parameters.AddWithValue("BoD", txtbod.Text);
            cmd2.Parameters.AddWithValue("Password", txtpassword.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered");
            conn.Close();
            bind_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtemployee_ID.Text = "";
            txtemployee_name.Text = "";
            txtage.Text = "";
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
            cbGender.Text = selectedrow.Cells[3].Value.ToString();
            cbPosition.Text = selectedrow.Cells[4].Value.ToString();
            txtcontact.Text = selectedrow.Cells[5].Value.ToString();
            txtaddress.Text = selectedrow.Cells[6].Value.ToString();
            txtbod.Text = selectedrow.Cells[7].Value.ToString();
            txtpassword.Text = selectedrow.Cells[8].Value.ToString();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Employee Set Name=@Name,Age=@Age,Gender=@Gender,Position=@Position,Contact=@Contact,Address=@Address,BoD=@BoD,Password=@Password Where ID=@ID", conn);
            cmd3.Parameters.AddWithValue("@Name", txtemployee_name.Text);
            cmd3.Parameters.AddWithValue("@Age", txtage.Text);
            cmd3.Parameters.AddWithValue("@Gender", cbGender.Text);
            cmd3.Parameters.AddWithValue("@Position", cbPosition.Text);
            cmd3.Parameters.AddWithValue("@Contact", float.Parse(txtcontact.Text));
            cmd3.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd3.Parameters.AddWithValue("@BoD", txtbod.Text);
            cmd3.Parameters.AddWithValue("@Password", txtpassword.Text);
            cmd3.Parameters.AddWithValue("@ID", txtemployee_ID.Text);
            conn.Open();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            conn.Close();
            bind_data();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from Employee where ID=@ID", conn);
            cmd4.Parameters.AddWithValue("ID", txtemployee_ID.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            conn.Close();
            bind_data();
        }
    }
}
