namespace Qforte
{
    partial class QforteAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QforteAdmin));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebartransmission = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menupanel = new System.Windows.Forms.Panel();
            this.btCalendar = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btViewEmployee = new System.Windows.Forms.Button();
            this.btSalary = new System.Windows.Forms.Button();
            this.btRequest = new System.Windows.Forms.Button();
            this.btAttendance = new System.Windows.Forms.Button();
            this.btManageEmployee = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 518);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(985, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // sidebartransmission
            // 
            this.sidebartransmission.Interval = 10;
            this.sidebartransmission.Tick += new System.EventHandler(this.sidebartransmission_Tick);
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(25, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(41, 37);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(935, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "QFORTE    |     EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 43);
            this.panel1.TabIndex = 3;
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.DimGray;
            this.menupanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menupanel.Controls.Add(this.btCalendar);
            this.menupanel.Controls.Add(this.btHome);
            this.menupanel.Controls.Add(this.btViewEmployee);
            this.menupanel.Controls.Add(this.btSalary);
            this.menupanel.Controls.Add(this.btRequest);
            this.menupanel.Controls.Add(this.btAttendance);
            this.menupanel.Controls.Add(this.btManageEmployee);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 43);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(183, 475);
            this.menupanel.TabIndex = 5;
            // 
            // btCalendar
            // 
            this.btCalendar.BackColor = System.Drawing.Color.DimGray;
            this.btCalendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalendar.ForeColor = System.Drawing.Color.White;
            this.btCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btCalendar.Image")));
            this.btCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalendar.Location = new System.Drawing.Point(4, 393);
            this.btCalendar.Name = "btCalendar";
            this.btCalendar.Size = new System.Drawing.Size(174, 59);
            this.btCalendar.TabIndex = 9;
            this.btCalendar.Text = "         Callendar";
            this.btCalendar.UseVisualStyleBackColor = false;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.DimGray;
            this.btHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(4, 9);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(174, 57);
            this.btHome.TabIndex = 3;
            this.btHome.Text = "  Home";
            this.btHome.UseVisualStyleBackColor = false;
            // 
            // btViewEmployee
            // 
            this.btViewEmployee.BackColor = System.Drawing.Color.DimGray;
            this.btViewEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewEmployee.ForeColor = System.Drawing.Color.White;
            this.btViewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btViewEmployee.Image")));
            this.btViewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewEmployee.Location = new System.Drawing.Point(4, 135);
            this.btViewEmployee.Name = "btViewEmployee";
            this.btViewEmployee.Size = new System.Drawing.Size(174, 59);
            this.btViewEmployee.TabIndex = 5;
            this.btViewEmployee.Text = "View Employee";
            this.btViewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btViewEmployee.UseVisualStyleBackColor = false;
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.Color.DimGray;
            this.btSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalary.ForeColor = System.Drawing.Color.White;
            this.btSalary.Image = ((System.Drawing.Image)(resources.GetObject("btSalary.Image")));
            this.btSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalary.Location = new System.Drawing.Point(4, 199);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(174, 59);
            this.btSalary.TabIndex = 6;
            this.btSalary.Text = "    Salary";
            this.btSalary.UseVisualStyleBackColor = false;
            // 
            // btRequest
            // 
            this.btRequest.BackColor = System.Drawing.Color.DimGray;
            this.btRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRequest.ForeColor = System.Drawing.Color.White;
            this.btRequest.Image = ((System.Drawing.Image)(resources.GetObject("btRequest.Image")));
            this.btRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRequest.Location = new System.Drawing.Point(4, 327);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(174, 59);
            this.btRequest.TabIndex = 8;
            this.btRequest.Text = "       Request";
            this.btRequest.UseVisualStyleBackColor = false;
            // 
            // btAttendance
            // 
            this.btAttendance.BackColor = System.Drawing.Color.DimGray;
            this.btAttendance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttendance.ForeColor = System.Drawing.Color.White;
            this.btAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btAttendance.Image")));
            this.btAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttendance.Location = new System.Drawing.Point(4, 263);
            this.btAttendance.Name = "btAttendance";
            this.btAttendance.Size = new System.Drawing.Size(174, 59);
            this.btAttendance.TabIndex = 7;
            this.btAttendance.Text = "            Attendance";
            this.btAttendance.UseVisualStyleBackColor = false;
            // 
            // btManageEmployee
            // 
            this.btManageEmployee.BackColor = System.Drawing.Color.DimGray;
            this.btManageEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btManageEmployee.Image")));
            this.btManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManageEmployee.Location = new System.Drawing.Point(4, 71);
            this.btManageEmployee.Name = "btManageEmployee";
            this.btManageEmployee.Size = new System.Drawing.Size(174, 59);
            this.btManageEmployee.TabIndex = 4;
            this.btManageEmployee.Text = "     Manage";
            this.btManageEmployee.UseVisualStyleBackColor = false;
            this.btManageEmployee.Click += new System.EventHandler(this.btManageEmployee_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(183, 43);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(802, 475);
            this.mainpanel.TabIndex = 6;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // QforteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 550);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QforteAdmin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer sidebartransmission;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button btCalendar;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btViewEmployee;
        private System.Windows.Forms.Button btSalary;
        private System.Windows.Forms.Button btRequest;
        private System.Windows.Forms.Button btAttendance;
        private System.Windows.Forms.Button btManageEmployee;
        private System.Windows.Forms.Panel mainpanel;
    }
}