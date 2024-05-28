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
    public partial class FormAttend : Form
    {
        public FormAttend()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");
        private void FormAttend_Load(object sender, EventArgs e)
        {
            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select ID As ID,Name As Name,Position As Position,Time_In As Time_In,Time_Out As Time_Out,Date As Date from Attendance", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Position As Position,Time_In As Time_In,Time_Out As Time_Out,Date As Date from Attendance where ID Like @ID+'%'", conn);
            cmd1.Parameters.AddWithValue("ID", txtEmployee_ID.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
