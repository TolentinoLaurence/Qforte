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
            this.menupanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btCal = new FontAwesome.Sharp.IconButton();
            this.btManage = new FontAwesome.Sharp.IconButton();
            this.btRequest = new FontAwesome.Sharp.IconButton();
            this.btViewEmp = new FontAwesome.Sharp.IconButton();
            this.btAttendance = new FontAwesome.Sharp.IconButton();
            this.btSalary = new FontAwesome.Sharp.IconButton();
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
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.DimGray;
            this.menupanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menupanel.Controls.Add(this.iconButton1);
            this.menupanel.Controls.Add(this.btCal);
            this.menupanel.Controls.Add(this.btManage);
            this.menupanel.Controls.Add(this.btRequest);
            this.menupanel.Controls.Add(this.btViewEmp);
            this.menupanel.Controls.Add(this.btAttendance);
            this.menupanel.Controls.Add(this.btSalary);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 43);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(184, 479);
            this.menupanel.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(5, 17);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(174, 57);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Home";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.DimGray;
            this.btCal.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btCal.IconColor = System.Drawing.Color.Black;
            this.btCal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCal.Location = new System.Drawing.Point(4, 405);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(174, 57);
            this.btCal.TabIndex = 16;
            this.btCal.Text = "    Calendar";
            this.btCal.UseVisualStyleBackColor = false;
            // 
            // btManage
            // 
            this.btManage.BackColor = System.Drawing.Color.DimGray;
            this.btManage.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btManage.IconColor = System.Drawing.Color.Black;
            this.btManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManage.Location = new System.Drawing.Point(4, 80);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(174, 57);
            this.btManage.TabIndex = 11;
            this.btManage.Text = "Manage";
            this.btManage.UseVisualStyleBackColor = false;
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // btRequest
            // 
            this.btRequest.BackColor = System.Drawing.Color.DimGray;
            this.btRequest.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btRequest.IconColor = System.Drawing.Color.Black;
            this.btRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRequest.Location = new System.Drawing.Point(4, 340);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(174, 57);
            this.btRequest.TabIndex = 15;
            this.btRequest.Text = "    Request";
            this.btRequest.UseVisualStyleBackColor = false;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // btViewEmp
            // 
            this.btViewEmp.BackColor = System.Drawing.Color.DimGray;
            this.btViewEmp.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btViewEmp.IconColor = System.Drawing.Color.Black;
            this.btViewEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btViewEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewEmp.Location = new System.Drawing.Point(4, 145);
            this.btViewEmp.Name = "btViewEmp";
            this.btViewEmp.Size = new System.Drawing.Size(174, 57);
            this.btViewEmp.TabIndex = 12;
            this.btViewEmp.Text = "           View Employee";
            this.btViewEmp.UseVisualStyleBackColor = false;
            this.btViewEmp.Click += new System.EventHandler(this.btViewEmp_Click);
            // 
            // btAttendance
            // 
            this.btAttendance.BackColor = System.Drawing.Color.DimGray;
            this.btAttendance.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btAttendance.IconColor = System.Drawing.Color.Black;
            this.btAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttendance.Location = new System.Drawing.Point(4, 275);
            this.btAttendance.Name = "btAttendance";
            this.btAttendance.Size = new System.Drawing.Size(174, 57);
            this.btAttendance.TabIndex = 14;
            this.btAttendance.Text = "        Attendance";
            this.btAttendance.UseVisualStyleBackColor = false;
            this.btAttendance.Click += new System.EventHandler(this.btAttendance_Click);
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.Color.DimGray;
            this.btSalary.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btSalary.IconColor = System.Drawing.Color.Black;
            this.btSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalary.Location = new System.Drawing.Point(4, 210);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(174, 57);
            this.btSalary.TabIndex = 13;
            this.btSalary.Text = "Salary";
            this.btSalary.UseVisualStyleBackColor = false;
            this.btSalary.Click += new System.EventHandler(this.btSalary_Click);
            // 
            // mainpanel
            // 
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
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton btCal;
        private FontAwesome.Sharp.IconButton btRequest;
        private FontAwesome.Sharp.IconButton btAttendance;
        private FontAwesome.Sharp.IconButton btSalary;
        private FontAwesome.Sharp.IconButton btViewEmp;
        private FontAwesome.Sharp.IconButton btManage;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}