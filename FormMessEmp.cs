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
    public partial class FormMessEmp : Form
    {
        public FormMessEmp()
        {
            InitializeComponent();
            FormMess formMess = new FormMess();
        }
        private void formMess_RowApproved(object sender, EventArgs e)
        {
            MessageBox.Show("A row has been approved in FormMess.");
        }

        private void formMess_RowDeclined(object sender, EventArgs e)
        {
            MessageBox.Show("A row has been declined in FormMess.");
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
        private void Form1_Load(object sender, EventArgs e)
        {
            bind_data();
        }
         
        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into MessageRequest(ID,From_Date,To_Date,Date,Message)Values(@ID,@From_Date,@To_Date,@Date,@Message)",conn);
            cmd.Parameters.AddWithValue("ID", txtEmployee_ID.Text);
            cmd.Parameters.AddWithValue("From_Date", txtFrom.Text);
            cmd.Parameters.AddWithValue("To_Date", txtTo.Text);
            cmd.Parameters.AddWithValue("Date", txtDate.Text);
            cmd.Parameters.AddWithValue("Message", richTextBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered");
            conn.Close();
            bind_data();
        }
    }
}
