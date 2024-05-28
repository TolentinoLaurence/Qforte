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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QforteAdmin));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btManageEmployee = new System.Windows.Forms.Button();
            this.btAttendance = new System.Windows.Forms.Button();
            this.btRequest = new System.Windows.Forms.Button();
            this.btSalary = new System.Windows.Forms.Button();
            this.btViewEmployee = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btCalendar = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 522);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(987, 32);
            this.flowLayoutPanel2.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "|     EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 43);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(41, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "QFORTE";
            // 
            // btManageEmployee
            // 
            this.btManageEmployee.BackColor = System.Drawing.Color.DimGray;
            this.btManageEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btManageEmployee.Image")));
            this.btManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManageEmployee.Location = new System.Drawing.Point(4, 74);
            this.btManageEmployee.Name = "btManageEmployee";
            this.btManageEmployee.Size = new System.Drawing.Size(174, 59);
            this.btManageEmployee.TabIndex = 4;
            this.btManageEmployee.Text = "     Manage";
            this.btManageEmployee.UseVisualStyleBackColor = false;
            this.btManageEmployee.Click += new System.EventHandler(this.btManageEmployee_Click);
            // 
            // btAttendance
            // 
            this.btAttendance.BackColor = System.Drawing.Color.DimGray;
            this.btAttendance.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttendance.ForeColor = System.Drawing.Color.White;
            this.btAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btAttendance.Image")));
            this.btAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttendance.Location = new System.Drawing.Point(4, 281);
            this.btAttendance.Name = "btAttendance";
            this.btAttendance.Size = new System.Drawing.Size(174, 59);
            this.btAttendance.TabIndex = 7;
            this.btAttendance.Text = "            Attendance";
            this.btAttendance.UseVisualStyleBackColor = false;
            this.btAttendance.Click += new System.EventHandler(this.btAttendance_Click);
            // 
            // btRequest
            // 
            this.btRequest.BackColor = System.Drawing.Color.DimGray;
            this.btRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRequest.ForeColor = System.Drawing.Color.White;
            this.btRequest.Image = ((System.Drawing.Image)(resources.GetObject("btRequest.Image")));
            this.btRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRequest.Location = new System.Drawing.Point(4, 350);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(174, 59);
            this.btRequest.TabIndex = 8;
            this.btRequest.Text = "       Request";
            this.btRequest.UseVisualStyleBackColor = false;
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.Color.DimGray;
            this.btSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalary.ForeColor = System.Drawing.Color.White;
            this.btSalary.Image = ((System.Drawing.Image)(resources.GetObject("btSalary.Image")));
            this.btSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalary.Location = new System.Drawing.Point(4, 211);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(174, 59);
            this.btSalary.TabIndex = 6;
            this.btSalary.Text = "    Salary";
            this.btSalary.UseVisualStyleBackColor = false;
            this.btSalary.Click += new System.EventHandler(this.btSalary_Click);
            // 
            // btViewEmployee
            // 
            this.btViewEmployee.BackColor = System.Drawing.Color.DimGray;
            this.btViewEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewEmployee.ForeColor = System.Drawing.Color.White;
            this.btViewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btViewEmployee.Image")));
            this.btViewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewEmployee.Location = new System.Drawing.Point(4, 142);
            this.btViewEmployee.Name = "btViewEmployee";
            this.btViewEmployee.Size = new System.Drawing.Size(174, 59);
            this.btViewEmployee.TabIndex = 5;
            this.btViewEmployee.Text = "View Employee";
            this.btViewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btViewEmployee.UseVisualStyleBackColor = false;
            this.btViewEmployee.Click += new System.EventHandler(this.btViewEmployee_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.DimGray;
            this.btHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(4, 8);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(174, 57);
            this.btHome.TabIndex = 3;
            this.btHome.Text = "  Home";
            this.btHome.UseVisualStyleBackColor = false;
            // 
            // btCalendar
            // 
            this.btCalendar.BackColor = System.Drawing.Color.DimGray;
            this.btCalendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalendar.ForeColor = System.Drawing.Color.White;
            this.btCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btCalendar.Image")));
            this.btCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCalendar.Location = new System.Drawing.Point(6, 419);
            this.btCalendar.Name = "btCalendar";
            this.btCalendar.Size = new System.Drawing.Size(174, 59);
            this.btCalendar.TabIndex = 9;
            this.btCalendar.Text = "         Callendar";
            this.btCalendar.UseVisualStyleBackColor = false;
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
            this.menupanel.Size = new System.Drawing.Size(184, 479);
            this.menupanel.TabIndex = 5;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(184, 43);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(803, 479);
            this.mainpanel.TabIndex = 7;
            // 
            // QforteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QforteAdmin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btManageEmployee;
        private System.Windows.Forms.Button btAttendance;
        private System.Windows.Forms.Button btRequest;
        private System.Windows.Forms.Button btSalary;
        private System.Windows.Forms.Button btViewEmployee;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btCalendar;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel mainpanel;
    }
}