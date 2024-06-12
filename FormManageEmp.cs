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
using System.Drawing.Printing;

namespace Qforte
{
    public partial class FormManageEmp : Form
    {
        public FormManageEmp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        private void FormManageEmp_Load(object sender, EventArgs e)
        {
            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select ID As ID,Name As Name,Age As Age,Gender As Gender,Position As Position,Contact As Contact,Address As Address,Birthday As Birthday,Password As Password from Employee", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();

            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string maxIdQuery = "SELECT MAX(Id) FROM Employee";
            SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, conn);
            string maxId = getMaxIdCmd.ExecuteScalar() as string;
            int nextNumericPart = 1;

            if (!string.IsNullOrEmpty(maxId))
            {
                int numericPart;
                if (int.TryParse(maxId.Substring(3), out numericPart))
                {
                    nextNumericPart = numericPart + 1;
                }
            }

            string nextId = $"LPI{nextNumericPart:D3}";
            string query = "INSERT INTO Employee(ID, Name, Age, Gender, Position, Contact, Address, Birthday, Password) VALUES(@ID, @Name, @Age, @Gender, @Position, @Contact, @Address, @Birthday, @Password)";
            SqlCommand cmd2 = new SqlCommand(query, conn);
            cmd2.Parameters.AddWithValue("@ID", nextId);
            cmd2.Parameters.AddWithValue("@Name", txtemployee_name.Text);
            cmd2.Parameters.AddWithValue("@Age", int.Parse(txtage.Text));
            cmd2.Parameters.AddWithValue("@Gender", cbGender.Text);
            cmd2.Parameters.AddWithValue("@Position", cbPosition.Text);
            cmd2.Parameters.AddWithValue("@Contact", float.Parse(txtcontact.Text));
            cmd2.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd2.Parameters.AddWithValue("@Birthday", dateTimePicker1.Text);
            cmd2.Parameters.AddWithValue("@Password", txtpassword.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered");
            txtemployee_name.Text = "";
            txtage.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtpassword.Text = "";
            conn.Close();
            bind_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtemployee_name.Text = "";
            txtage.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtpassword.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtemployee_name.Text = selectedrow.Cells[1].Value.ToString();
            txtage.Text = selectedrow.Cells[2].Value.ToString();
            cbGender.Text = selectedrow.Cells[3].Value.ToString();
            cbPosition.Text = selectedrow.Cells[4].Value.ToString();
            txtcontact.Text = selectedrow.Cells[5].Value.ToString();
            txtaddress.Text = selectedrow.Cells[6].Value.ToString();
            dateTimePicker1.Text = selectedrow.Cells[7].Value.ToString();
            txtpassword.Text = selectedrow.Cells[8].Value.ToString();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Update Employee Set Name=@Name,Age=@Age,Gender=@Gender,Position=@Position,Contact=@Contact,Address=@Address,Birthday=@Birthday,Password=@Password Where ID=@ID", conn);
            string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            cmd3.Parameters.AddWithValue("ID", ID);
            cmd3.Parameters.AddWithValue("@Name", txtemployee_name.Text);
            cmd3.Parameters.AddWithValue("@Age", txtage.Text);
            cmd3.Parameters.AddWithValue("@Gender", cbGender.Text);
            cmd3.Parameters.AddWithValue("@Position", cbPosition.Text);
            cmd3.Parameters.AddWithValue("@Contact", float.Parse(txtcontact.Text));
            cmd3.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd3.Parameters.AddWithValue("@Birthday", dateTimePicker1.Text);
            cmd3.Parameters.AddWithValue("@Password", txtpassword.Text);
            conn.Open();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            conn.Close();
            bind_data();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            SqlCommand cmd4 = new SqlCommand("Delete from Employee where ID=@ID", conn);
            cmd4.Parameters.AddWithValue("ID", ID);
            conn.Open();
            cmd4.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            int age = CalculateAge(birthDate);
            txtage.Text = age.ToString();
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0,0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 10, 20);
        }
    }
}
