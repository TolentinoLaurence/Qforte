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

                float SSSDeduction = 0;
                float PhilHealthDeduction = 0;
                float HDMFDeduction = 0;

                if (cbhSSS.Checked)
                {
                    SSSDeduction = CalculateDeduction("SSS", Salary);
                    Salary -= SSSDeduction;
                }
                if (chbPHILHEALTH.Checked)
                {
                    PhilHealthDeduction = CalculateDeduction("PHILHEALTH", Salary);
                    Salary -= PhilHealthDeduction;
                }
                if (chbHDMF.Checked)
                {
                    HDMFDeduction = CalculateDeduction("HDMF", Salary);
                    Salary -= HDMFDeduction;
                }

                // Display information in RichTextBox
                SalarySlip.Clear();
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("QForte Employee Employment\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nEmployee ID: " + txtEmployee_ID.Text + "\n");
                SalarySlip.AppendText("\nName: " + txtname.Text + "\n");
                SalarySlip.AppendText("\nPosition: " + txtPosition.Text + "\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nRate Per Day: " + RatePerDay.ToString("0.00") + "\n");
                SalarySlip.AppendText("\nWork Days: " + WorkDays.ToString() + "\n");
                SalarySlip.AppendText("\n\nDeductions\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nSSS: " + SSSDeduction.ToString("0.00") + "   (Deducted from Salary: " + (SSSDeduction > 0 ? (Salary + SSSDeduction).ToString("0.00") : "N/A") + ")\n");
                SalarySlip.AppendText("\nPHILHEALTH: " + PhilHealthDeduction.ToString("0.00") + "   (Deducted from Salary: " + (PhilHealthDeduction > 0 ? (Salary + PhilHealthDeduction).ToString("0.00") : "N/A") + ")\n");
                SalarySlip.AppendText("\nHDMF: " + HDMFDeduction.ToString("0.00") + "   (Deducted from Salary: " + (HDMFDeduction > 0 ? (Salary + HDMFDeduction).ToString("0.00") : "N/A") + ")\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nTotal Salary: " + Salary.ToString("0.00") + "\n");
                SalarySlip.AppendText("-------------------------------------------------------------------------------------------------------------------------------------\n");
                SalarySlip.AppendText("\nDate: " + DateTime.Now.ToString("yyyy-MM-dd") + "\n");
                SalarySlip.AppendText("\nTime: " + DateTime.Now.ToString("hh:mm tt") + "\n");

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