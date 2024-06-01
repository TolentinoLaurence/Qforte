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
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Age As Age,Gender As Gender,Position As Position,Contact As Contact,Address As Address,BOD As BoD,Password As Password from Employee", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }

        private void fetchdata()
        {
            conn.Open();
            string querry = "select * from Employee";
            SqlCommand cmd = new SqlCommand(querry, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
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
                    txtBod.Text = dr["BoD"].ToString();
                    txtPassword.Text = dr["Password"].ToString();
                    txtEmployee_ID.Visible = true;
                    txtEmployee_name.Visible = true;
                    txtAge.Visible = true;
                    txtGender.Visible = true;
                    txtPosition.Visible = true;
                    txtContact.Visible = true;
                    txtAddress.Visible = true;
                    txtBod.Visible = true;
                    txtPassword.Visible = true;
                }           
            conn.Close();
        }
        private void FormViewProf_Load(object sender, EventArgs e)
        {
            fetchdata();
            bind_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Employee Set Contact=@Contact,Address=@Address,Password=@Password Where ID=@ID", conn);         
            cmd2.Parameters.AddWithValue("@Contact", float.Parse(txtContact.Text));
            cmd2.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd2.Parameters.AddWithValue("@Password", txtPassword.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            conn.Close();
            bind_data();
        }
    }
}
