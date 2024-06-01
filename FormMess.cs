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

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MessageRequest", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btApprove_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            MessageBox.Show("Your request has been approved");
        }

        private void btDecline_Click(object sender, EventArgs e)
        {

        }
    }
}
