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
    public partial class FormCalEvent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BOTTGEF\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;");

        public FormCalEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Calendar(Date,Event)Values(@Date,@Event)", conn);
            cmd.Parameters.AddWithValue("Date", txtDate.Text);
            cmd.Parameters.AddWithValue("Event", txtEvent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event has been saved");
            cmd.Dispose();
            conn.Close();
        }

        private void FormCalEvent_Load(object sender, EventArgs e)
        {
            txtDate.Text = FormCalendar.static_month+"/"+ UserControlDays.static_day+"/"+ FormCalendar.static_year;
        }
    }
}
