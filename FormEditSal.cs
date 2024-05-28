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
    public partial class FormEditSal : Form
    {
        public FormEditSal()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");
        private void FormEditSal_Load(object sender, EventArgs e)
        {
            Salary_data();
            bind_data();
        }
        private void Salary_data()
        {
            conn.Open();
            string querry = "select * from Salary";
            SqlCommand cmd1 = new SqlCommand(querry, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            ad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtCrew.Text = dr["Crew"].ToString();
                txtDeliveryDriver.Text = dr["Delivery_Driver"].ToString();
                txtDeliveryHelper.Text = dr["Delivery_Helper"].ToString();
                txtProductChecker.Text = dr["Product_Checker"].ToString();
                txtSSS.Text = dr["SSS"].ToString();
                txtPhilhealth.Text = dr["PHILHEALTH"].ToString();
                txtHDMF.Text = dr["HDMF"].ToString();
                txtCrew.Visible = true;
                txtDeliveryDriver.Visible = true;
                txtDeliveryHelper.Visible = true;
                txtProductChecker.Visible = true;
                txtSSS.Visible = true;
                txtPhilhealth.Visible = true;
                txtHDMF.Visible = true;
            }
            conn.Close();
        }

        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select ID,Crew,Delivery_Driver,Delivery_Helper,Product_Checker,SSS,PHILHEALTH,HDMF from Salary ", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("UPDATE Salary SET Crew=@Crew, Delivery_Driver=@Delivery_Driver, Delivery_Helper=@Delivery_Helper, Product_Checker=@Product_Checker, SSS=@SSS, PHILHEALTH=@PHILHEALTH, HDMF=@HDMF", conn);
            cmd2.Parameters.AddWithValue("@Crew", float.Parse(txtCrew.Text));
            cmd2.Parameters.AddWithValue("@Delivery_Driver", float.Parse(txtDeliveryDriver.Text));
            cmd2.Parameters.AddWithValue("@Delivery_Helper", float.Parse(txtDeliveryHelper.Text));
            cmd2.Parameters.AddWithValue("@Product_Checker", float.Parse(txtProductChecker.Text));
            cmd2.Parameters.AddWithValue("@SSS", float.Parse(txtSSS.Text));
            cmd2.Parameters.AddWithValue("@PHILHEALTH", float.Parse(txtPhilhealth.Text));
            cmd2.Parameters.AddWithValue("@HDMF", float.Parse(txtHDMF.Text));
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            FormEditSal formEditSal = new FormEditSal();
            this.Close();
        }
    }
}
