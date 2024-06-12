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
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Position, Time_In, Time_Out, Date FROM Attendance WHERE Date LIKE @SearchText OR Name LIKE @SearchText OR ID LIKE @SearchText", conn);
            cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
