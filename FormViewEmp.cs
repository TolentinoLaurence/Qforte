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
    public partial class FormViewEmp : Form
    {
        public FormViewEmp()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");
        private void fetchdata()
        {
            conn.Open();
            string querry = "select * from Employee where ID='" + Employee_ID.Text + "'";
            SqlCommand cmd = new SqlCommand(querry,conn);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            if (Employee_ID.Text == "")
            {
                MessageBox.Show("Enter Valid Employee ID");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblEmployeeID.Text = dr["ID"].ToString();
                    lblName.Text = dr["Name"].ToString();
                    lblAge.Text = dr["Age"].ToString();
                    lblGender.Text = dr["Gender"].ToString();
                    lblPosition.Text = dr["Position"].ToString();
                    lblContact.Text = dr["Contact"].ToString();
                    lblAddress.Text = dr["Address"].ToString();
                    lblBirthday.Text = dr["BoD"].ToString();
                    lblEmployeeID.Visible = true;
                    lblName.Visible = true;
                    lblAge.Visible = true;
                    lblGender.Visible = true;
                    lblPosition.Visible = true;
                    lblContact.Visible = true;
                    lblAddress.Visible = true;
                    lblBirthday.Visible = true;
                }
            }
            conn.Close();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void FormViewEmp_Load(object sender, EventArgs e)
        {

        }
    }
}

