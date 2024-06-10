using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            SqlCommand cmd = new SqlCommand("Select Request_ID As Request_ID, ID As ID,Name As Name,From_Date As From_Date,To_Date As To_Date,Date As Date, Message As Message from MessageRequest", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string Request_ID = dataGridView1.SelectedRows[0].Cells["Request_ID"].Value.ToString();
            SqlCommand cmd4 = new SqlCommand("Delete from MessageRequest where Request_ID=@Request_ID", conn);
            cmd4.Parameters.AddWithValue("Request_ID", Request_ID);
            conn.Open();
            cmd4.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            conn.Close();
        }

        private void FormMess_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void bind_data1()
        {
            SqlCommand cmd2 = new SqlCommand("Select Request_ID As Request_ID,ID As ID, Name As Name,Date As Date,From_date As From_date,To_Date As To_Date,Message As Message,Decision As Decision from RecordRequest", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            conn.Open();
            cmd2.ExecuteNonQuery();
            dt.Clear();
            da.Fill(dt);
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            string maxIdQuery = "SELECT MAX(Record_ID) FROM RecordRequest";
            SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, conn);
            string maxId;

            conn.Open();

            maxId = getMaxIdCmd.ExecuteScalar() as string;
            int nextNumericPart = 1;

            if (!string.IsNullOrEmpty(maxId))
            {
                int numericPart;
                if (int.TryParse(maxId.Substring(3), out numericPart))
                {
                    nextNumericPart = numericPart + 1;
                }
            }

            string nextId = $"REC{nextNumericPart:D3}";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string Request_id = selectedRow.Cells["Request_ID"].Value.ToString();
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string date = selectedRow.Cells["Date"].Value.ToString();
                string from_date = selectedRow.Cells["From_date"].Value.ToString();
                string to_date = selectedRow.Cells["To_date"].Value.ToString();
                string message = selectedRow.Cells["Message"].Value.ToString();

                SqlCommand cmd3 = new SqlCommand("INSERT INTO RecordRequest (Record_ID, ID, Name, Date, From_date, To_date, Message, Request_ID, Decision) VALUES (@Record_ID, @ID, @Name, @Date, @From_date, @To_date, @Message, @Request_ID, @Decision)", conn);
                cmd3.Parameters.AddWithValue("@Record_ID", nextId);
                cmd3.Parameters.AddWithValue("ID", ID);
                cmd3.Parameters.AddWithValue("@Request_ID", Request_id);
                cmd3.Parameters.AddWithValue("@Name", name);
                cmd3.Parameters.AddWithValue("@Date", date);
                cmd3.Parameters.AddWithValue("@From_date", from_date);
                cmd3.Parameters.AddWithValue("@To_date", to_date);
                cmd3.Parameters.AddWithValue("@Message", message);
                cmd3.Parameters.AddWithValue("@Decision", "Approved");
                MessageBox.Show("The Request has been Approved.");
                cmd3.ExecuteNonQuery();
            }

            conn.Close();
            bind_data1();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string maxIdQuery = "SELECT MAX(Record_ID) FROM RecordRequest";
            SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, conn);
            string maxId;

            conn.Open();

            maxId = getMaxIdCmd.ExecuteScalar() as string;
            int nextNumericPart = 1;

            if (!string.IsNullOrEmpty(maxId))
            {
                int numericPart;
                if (int.TryParse(maxId.Substring(3), out numericPart))
                {
                    nextNumericPart = numericPart + 1;
                }
            }

            string nextId = $"REC{nextNumericPart:D3}";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string Request_id = selectedRow.Cells["Request_ID"].Value.ToString();
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string date = selectedRow.Cells["Date"].Value.ToString();
                string from_date = selectedRow.Cells["From_date"].Value.ToString();
                string to_date = selectedRow.Cells["To_date"].Value.ToString();
                string message = selectedRow.Cells["Message"].Value.ToString();

                SqlCommand cmd3 = new SqlCommand("INSERT INTO RecordRequest (Record_ID, ID, Name, Date, From_date, To_date, Message, Request_ID, Decision) VALUES (@Record_ID, @ID, @Name, @Date, @From_date, @To_date, @Message, @Request_ID, @Decision)", conn);
                cmd3.Parameters.AddWithValue("@Record_ID", nextId);
                cmd3.Parameters.AddWithValue("ID", ID);
                cmd3.Parameters.AddWithValue("@Request_ID", Request_id);
                cmd3.Parameters.AddWithValue("@Name", name);
                cmd3.Parameters.AddWithValue("@Date", date);
                cmd3.Parameters.AddWithValue("@From_date", from_date);
                cmd3.Parameters.AddWithValue("@To_date", to_date);
                cmd3.Parameters.AddWithValue("@Message", message);
                cmd3.Parameters.AddWithValue("@Decision", "Declined");
                MessageBox.Show("The Request has been Declined.");
                cmd3.ExecuteNonQuery();
            }

            conn.Close();
            bind_data1();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormMessageRecords formMessageRecords = new FormMessageRecords();
            formMessageRecords.Show();
        }
    }
}