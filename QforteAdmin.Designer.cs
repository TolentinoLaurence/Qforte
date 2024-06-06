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
            this.menupanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btCal = new FontAwesome.Sharp.IconButton();
            this.btManage = new FontAwesome.Sharp.IconButton();
            this.btRequest = new FontAwesome.Sharp.IconButton();
            this.btViewEmp = new FontAwesome.Sharp.IconButton();
            this.btAttendance = new FontAwesome.Sharp.IconButton();
            this.btSalary = new FontAwesome.Sharp.IconButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 539);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1004, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.menupanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menupanel.Controls.Add(this.pictureBox1);
            this.menupanel.Controls.Add(this.iconButton1);
            this.menupanel.Controls.Add(this.btCal);
            this.menupanel.Controls.Add(this.btManage);
            this.menupanel.Controls.Add(this.btRequest);
            this.menupanel.Controls.Add(this.btViewEmp);
            this.menupanel.Controls.Add(this.btAttendance);
            this.menupanel.Controls.Add(this.btSalary);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(184, 539);
            this.menupanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 99);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(174, 57);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Home";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btCal.FlatAppearance.BorderSize = 0;
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCal.ForeColor = System.Drawing.Color.White;
            this.btCal.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btCal.IconColor = System.Drawing.Color.White;
            this.btCal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCal.Location = new System.Drawing.Point(4, 477);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(174, 57);
            this.btCal.TabIndex = 16;
            this.btCal.Text = "    Calendar";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btManage
            // 
            this.btManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btManage.FlatAppearance.BorderSize = 0;
            this.btManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManage.ForeColor = System.Drawing.Color.White;
            this.btManage.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btManage.IconColor = System.Drawing.Color.White;
            this.btManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManage.Location = new System.Drawing.Point(4, 162);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(174, 57);
            this.btManage.TabIndex = 11;
            this.btManage.Text = "Manage";
            this.btManage.UseVisualStyleBackColor = false;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btRequest
            // 
            this.btRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btRequest.FlatAppearance.BorderSize = 0;
            this.btRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRequest.ForeColor = System.Drawing.Color.White;
            this.btRequest.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btRequest.IconColor = System.Drawing.Color.White;
            this.btRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRequest.Location = new System.Drawing.Point(4, 414);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(174, 57);
            this.btRequest.TabIndex = 15;
            this.btRequest.Text = "    Request";
            this.btRequest.UseVisualStyleBackColor = false;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // btViewEmp
            // 
            this.btViewEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btViewEmp.FlatAppearance.BorderSize = 0;
            this.btViewEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btViewEmp.ForeColor = System.Drawing.Color.White;
            this.btViewEmp.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btViewEmp.IconColor = System.Drawing.Color.White;
            this.btViewEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btViewEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewEmp.Location = new System.Drawing.Point(3, 225);
            this.btViewEmp.Name = "btViewEmp";
            this.btViewEmp.Size = new System.Drawing.Size(174, 57);
            this.btViewEmp.TabIndex = 12;
            this.btViewEmp.Text = "           View Employee";
            this.btViewEmp.UseVisualStyleBackColor = false;
            this.btViewEmp.Click += new System.EventHandler(this.btViewEmp_Click);
            // 
            // btAttendance
            // 
            this.btAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btAttendance.FlatAppearance.BorderSize = 0;
            this.btAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttendance.ForeColor = System.Drawing.Color.White;
            this.btAttendance.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btAttendance.IconColor = System.Drawing.Color.White;
            this.btAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttendance.Location = new System.Drawing.Point(4, 351);
            this.btAttendance.Name = "btAttendance";
            this.btAttendance.Size = new System.Drawing.Size(174, 57);
            this.btAttendance.TabIndex = 14;
            this.btAttendance.Text = "        Attendance";
            this.btAttendance.UseVisualStyleBackColor = false;
            this.btAttendance.Click += new System.EventHandler(this.btAttendance_Click);
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.btSalary.FlatAppearance.BorderSize = 0;
            this.btSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalary.ForeColor = System.Drawing.Color.White;
            this.btSalary.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btSalary.IconColor = System.Drawing.Color.White;
            this.btSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalary.Location = new System.Drawing.Point(4, 288);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(174, 57);
            this.btSalary.TabIndex = 13;
            this.btSalary.Text = "Salary";
            this.btSalary.UseVisualStyleBackColor = false;
            this.btSalary.Click += new System.EventHandler(this.btSalary_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainpanel.Location = new System.Drawing.Point(184, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(820, 539);
            this.mainpanel.TabIndex = 7;
            // 
            // QforteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QforteAdmin";
            this.Text = "QFORTE EMPLOYEE MANAGEMENT SYSTEM";
            this.menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton btCal;
        private FontAwesome.Sharp.IconButton btRequest;
        private FontAwesome.Sharp.IconButton btAttendance;
        private FontAwesome.Sharp.IconButton btSalary;
        private FontAwesome.Sharp.IconButton btViewEmp;
        private FontAwesome.Sharp.IconButton btManage;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}