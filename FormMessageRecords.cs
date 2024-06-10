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
    public partial class FormMessageRecords : Form
    {
        public FormMessageRecords()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select Request_ID As Request_ID, ID As ID,Name As Name,From_Date As From_Date,To_Date As To_Date,Date As Date, Message As Message, Decision As Decision, Record_ID As Record_ID from RecordRequest", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();

            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormMessageRecords_Load(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}
