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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");


        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;

            timer1.Start();
            FormCalEvent formCalEvent = new FormCalEvent();
            formCalEvent.Show();
        }

        private void displayEvent()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Calendar where Date=@Date", conn);
            cmd.Parameters.AddWithValue("Date", FormCalendar.static_month + "/" + UserControlDays.static_day + "/" + FormCalendar.static_year);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbEvent.Text = reader["Event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
