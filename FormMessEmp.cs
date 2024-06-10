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
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Age As Age,Gender As Gender,Position As Position,Contact As Contact,Address As Address,Birthday As Birthday,Password As Password from Employee", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bind_data();
            fetchdata();
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
                txtName.Text = dr["Name"].ToString();
                txtEmployee_ID.Visible = true;
                txtName.Visible = true;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maxIdQuery = "SELECT MAX(Request_ID) FROM MessageRequest";
            SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, conn);

            conn.Open();
            object result = getMaxIdCmd.ExecuteScalar();
            conn.Close();

            int nextNumericPart = 1;

            if (result != DBNull.Value)
            {
                if (result is int)
                {
                    nextNumericPart = (int)result + 1;
                }
                else if (result is string)
                {
                    string maxId = (string)result;
                    int numericPart;
                    if (int.TryParse(maxId.Substring(3), out numericPart))
                    {
                        nextNumericPart = numericPart + 1;
                    }
                }
            }

            string nextId = $"REQ{nextNumericPart:D3}";
            SqlCommand cmd = new SqlCommand("Insert into MessageRequest(Request_ID,ID, Name, Date, From_date, To_date, Message) Values(@Request_ID,@ID, @Name, @Date, @From_date, @To_date, @Message)", conn);
            cmd.Parameters.AddWithValue("Request_ID", nextId);
            cmd.Parameters.AddWithValue("@ID", txtEmployee_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@From_date", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@To_date", dateTimePicker3.Value);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("Message", radioButton1.Checked == true ? "Male" : "Female");

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your request has been submitted successfully");
            conn.Close();
            bind_data();
        }
    }
}
