using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Qforte
{
    public partial class FormViewProf : Form
    {
        public FormViewProf()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Age As Age,Gender As Gender,Position As Position,Contact As Contact,Address As Address,Birthday As Birthday,Password As Password from Employee", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }

        private void FormViewProf_Load(object sender, EventArgs e)
        {
            fetchData();
            bind_data();
        }

        private void fetchData()
        {
            conn.Open();
            string query = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtEmployee_ID.Text = dr["ID"].ToString();
                txtEmployee_name.Text = dr["Name"].ToString();
                txtAge.Text = dr["Age"].ToString();
                txtGender.Text = dr["Gender"].ToString();
                txtPosition.Text = dr["Position"].ToString();
                txtContact.Text = dr["Contact"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["Birthday"]);
                txtPassword.Text = dr["Password"].ToString();

                txtEmployee_ID.Visible = true;
                txtEmployee_name.Visible = true;
                txtAge.Visible = true;
                txtGender.Visible = true;
                txtPosition.Visible = true;
                txtContact.Visible = true;
                txtAddress.Visible = true;
                dateTimePicker1.Visible = true;
                txtPassword.Visible = true;
            }
            conn.Close();
            bind_data();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("Update Employee Set Contact=@Contact, Address=@Address, Password=@Password", conn);
                cmd3.Parameters.AddWithValue("@Contact", float.Parse(txtContact.Text));
                cmd3.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd3.Parameters.AddWithValue("@Password", txtPassword.Text);
                int rowsAffected = cmd3.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated");
                    bind_data();
                }
                else
                {
                    MessageBox.Show("Update failed");
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtContact.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtPassword.Enabled = true;
        }
    }
}
