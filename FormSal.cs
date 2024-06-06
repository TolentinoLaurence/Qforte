using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Qforte
{
    public partial class FormSal : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        public FormSal()
        {
            InitializeComponent();
        }

        private void fetchdata()
        {
            conn.Open();
            string querry = "SELECT * FROM Employee WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.Parameters.AddWithValue("@ID", txtEmployee_ID.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtname.Text = reader["Name"].ToString();
                txtPosition.Text = reader["position"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }

            conn.Close();
        }

        private void btFetchData_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float RatePerDay = 0;

            if (txtPosition.Text == "Crew")
            {
                RatePerDay = GetRatePerHour("Crew");
            }
            else if (txtPosition.Text == "Delivery Driver")
            {
                RatePerDay = GetRatePerHour("Delivery_Driver");
            }
            else if (txtPosition.Text == "Delivery Helper")
            {
                RatePerDay = GetRatePerHour("Delivery_Helper");
            }
            else if (txtPosition.Text == "Product Checker")
            {
                RatePerDay = GetRatePerHour("Product_Checker");
            }

            float WorkDays = 0;
            if (float.TryParse(txtWork_day.Text, out WorkDays))
            {
                float Salary = WorkDays * RatePerDay;

                if (cbhSSS.Checked)
                {
                    Salary -= CalculateDeduction("SSS", Salary);
                }
                if (chbPHILHEALTH.Checked)
                {
                    Salary -= CalculateDeduction("PHILHEALTH", Salary);
                }
                if (chbHDMF.Checked)
                {
                    Salary -= CalculateDeduction("HDMF", Salary);
                    // Display information in RichTextBox
                    SalarySlip.Clear();
                    SalarySlip.AppendText("QForte Employee Employment\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("\nEmployee ID: " + txtEmployee_ID.Text + "\n");
                    SalarySlip.AppendText("\nName: " + txtname.Text + "\n");
                    SalarySlip.AppendText("\nPosition: " + txtPosition.Text + "\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("\nRate Per Hour: " + RatePerDay.ToString("0.00") + "\n");
                    SalarySlip.AppendText("\nnWork Days: " + WorkDays.ToString() + "\n");
                    SalarySlip.AppendText("\n" + "\n" + "\n");
                    SalarySlip.AppendText("\nDeduction\n");
                    SalarySlip.AppendText("\n-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("\nSSS: \n");
                    SalarySlip.AppendText("\nPHILHEALTH: \n");
                    SalarySlip.AppendText("\nHDMF: \n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("\nWork Days: " + WorkDays.ToString() + "\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("\nTotal Salary: " + Salary.ToString("0.00") + "\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                    SalarySlip.Visible = true;
                }

                // Display information in RichTextBox
                SalarySlip.Clear();
                SalarySlip.AppendText("QForte Employee Employment\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nEmployee ID: " + txtEmployee_ID.Text + "\n");
                SalarySlip.AppendText("\nName: " + txtname.Text + "\n");
                SalarySlip.AppendText("\nPosition: " + txtPosition.Text + "\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nRate Per Hour: " + RatePerDay.ToString("0.00") + "\n");
                SalarySlip.AppendText("\nnWork Days: " + WorkDays.ToString() + "\n");
                SalarySlip.AppendText("\n" + "\n" + "\n");
                SalarySlip.AppendText("\nDeduction\n");
                SalarySlip.AppendText("\n-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nSSS: \n" );
                SalarySlip.AppendText("\nPHILHEALTH: \n");
                SalarySlip.AppendText("\nHDMF: \n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nWork Days: " + WorkDays.ToString() + "\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nTotal Salary: " + Salary.ToString("0.00") + "\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------\n");
                SalarySlip.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid work days input.");
            }
        }


        private float GetRatePerHour(string position)
        {
            float rate = 0;
            conn.Open();
            string query = "SELECT " + position + " FROM Salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                float.TryParse(reader[position].ToString(), out rate);
            }
            conn.Close();
            return rate;
        }

        private float CalculateDeduction(string deductionType, float Salary)
        {
            float deduction = 0;
            conn.Open();
            string query = "SELECT " + deductionType + " FROM Salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                float.TryParse(reader[deductionType].ToString(), out deduction);
                deduction *= Salary;
            }
            conn.Close();
            return deduction;
        }

        private void btEditSal_Click(object sender, EventArgs e)
        {
            FormEditSal formEditSal = new FormEditSal();
            formEditSal.Show();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(SalarySlip.Text, SalarySlip.Font, Brushes.Black, 100, 100);
        }

        private void btPrintData_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            pd.Print();
        }

        private void FormSal_Load(object sender, EventArgs e)
        {

        }
    }

}