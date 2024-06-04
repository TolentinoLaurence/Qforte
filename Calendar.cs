using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qforte
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }
        private void Calendar_Load(object sender, EventArgs e)
        {

        }
        private void InitializeCalendar()
        {
            // Create a new MonthCalendar control
            MonthCalendar calendar = new MonthCalendar();

            // Set its location and size
            calendar.Location = new System.Drawing.Point(10, 10);
            calendar.Size = new System.Drawing.Size(200, 150);

            // Add the calendar to the form's controls
            this.Controls.Add(calendar);
        }
    }
}
