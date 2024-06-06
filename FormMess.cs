using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qforte
{
    public partial class FormMess : Form
    {
        public FormMess()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");
        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select ID As ID,Name As Name,From_Date As From_Date,To_Date As To_Date,Date As Date, Message As Message from MessageRequest", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Delete * from MessageRequest where Message@Message", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            cmd1.Parameters.AddWithValue("Message", dataGridView1.Rows);
            conn.Open();
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt); 
            dataGridView1.DataSource = dt;
            MessageBox.Show("Successfully Deleted");
            conn.Close();
        }

        private void FormMess_Load(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}