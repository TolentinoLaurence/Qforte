namespace Qforte
{
    partial class FormSal
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
            this.btFetchData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmployee_ID = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWork_day = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btEditSal = new System.Windows.Forms.Button();
            this.btPrintData = new System.Windows.Forms.Button();
            this.cbhSSS = new System.Windows.Forms.CheckBox();
            this.chbPHILHEALTH = new System.Windows.Forms.CheckBox();
            this.chbHDMF = new System.Windows.Forms.CheckBox();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btFetchData
            // 
            this.btFetchData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btFetchData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFetchData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFetchData.ForeColor = System.Drawing.Color.White;
            this.btFetchData.Location = new System.Drawing.Point(259, 22);
            this.btFetchData.Name = "btFetchData";
            this.btFetchData.Size = new System.Drawing.Size(92, 30);
            this.btFetchData.TabIndex = 34;
            this.btFetchData.Text = "Fetch Data";
            this.btFetchData.UseVisualStyleBackColor = false;
            this.btFetchData.Click += new System.EventHandler(this.btFetchData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "ID:";
            // 
            // txtEmployee_ID
            // 
            this.txtEmployee_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmployee_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployee_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee_ID.Location = new System.Drawing.Point(85, 26);
            this.txtEmployee_ID.Name = "txtEmployee_ID";
            this.txtEmployee_ID.Size = new System.Drawing.Size(168, 20);
            this.txtEmployee_ID.TabIndex = 32;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(54, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(185, 20);
            this.txtname.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(55, 161);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(184, 20);
            this.txtPosition.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Worked Days";
            // 
            // txtWork_day
            // 
            this.txtWork_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWork_day.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWork_day.Location = new System.Drawing.Point(54, 228);
            this.txtWork_day.Name = "txtWork_day";
            this.txtWork_day.Size = new System.Drawing.Size(130, 27);
            this.txtWork_day.TabIndex = 40;
            this.txtWork_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 41;
            this.button1.Text = "Calculate Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditSal
            // 
            this.btEditSal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btEditSal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditSal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditSal.ForeColor = System.Drawing.Color.White;
            this.btEditSal.Location = new System.Drawing.Point(680, 12);
            this.btEditSal.Name = "btEditSal";
            this.btEditSal.Size = new System.Drawing.Size(92, 36);
            this.btEditSal.TabIndex = 43;
            this.btEditSal.Text = "Edit Salary";
            this.btEditSal.UseVisualStyleBackColor = false;
            this.btEditSal.Click += new System.EventHandler(this.btEditSal_Click);
            // 
            // btPrintData
            // 
            this.btPrintData.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btPrintData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPrintData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintData.ForeColor = System.Drawing.Color.White;
            this.btPrintData.Location = new System.Drawing.Point(556, 423);
            this.btPrintData.Name = "btPrintData";
            this.btPrintData.Size = new System.Drawing.Size(95, 30);
            this.btPrintData.TabIndex = 44;
            this.btPrintData.Text = "Print";
            this.btPrintData.UseVisualStyleBackColor = false;
            this.btPrintData.Click += new System.EventHandler(this.btPrintData_Click);
            // 
            // cbhSSS
            // 
            this.cbhSSS.AutoSize = true;
            this.cbhSSS.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhSSS.Location = new System.Drawing.Point(52, 274);
            this.cbhSSS.Name = "cbhSSS";
            this.cbhSSS.Size = new System.Drawing.Size(47, 20);
            this.cbhSSS.TabIndex = 45;
            this.cbhSSS.Text = "SSS";
            this.cbhSSS.UseVisualStyleBackColor = true;
            // 
            // chbPHILHEALTH
            // 
            this.chbPHILHEALTH.AutoSize = true;
            this.chbPHILHEALTH.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPHILHEALTH.Location = new System.Drawing.Point(133, 274);
            this.chbPHILHEALTH.Name = "chbPHILHEALTH";
            this.chbPHILHEALTH.Size = new System.Drawing.Size(97, 20);
            this.chbPHILHEALTH.TabIndex = 46;
            this.chbPHILHEALTH.Text = "PHILHEALTH";
            this.chbPHILHEALTH.UseVisualStyleBackColor = true;
            // 
            // chbHDMF
            // 
            this.chbHDMF.AutoSize = true;
            this.chbHDMF.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHDMF.Location = new System.Drawing.Point(255, 274);
            this.chbHDMF.Name = "chbHDMF";
            this.chbHDMF.Size = new System.Drawing.Size(61, 20);
            this.chbHDMF.TabIndex = 47;
            this.chbHDMF.Text = "HDMF";
            this.chbHDMF.UseVisualStyleBackColor = true;
            // 
            // SalarySlip
            // 
            this.SalarySlip.Location = new System.Drawing.Point(409, 59);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(363, 341);
            this.SalarySlip.TabIndex = 48;
            this.SalarySlip.Text = "";
            // 
            // FormSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 539);
            this.Controls.Add(this.SalarySlip);
            this.Controls.Add(this.chbHDMF);
            this.Controls.Add(this.chbPHILHEALTH);
            this.Controls.Add(this.cbhSSS);
            this.Controls.Add(this.btPrintData);
            this.Controls.Add(this.btEditSal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWork_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFetchData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmployee_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFetchData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmployee_ID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWork_day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEditSal;
        private System.Windows.Forms.Button btPrintData;
        private System.Windows.Forms.CheckBox cbhSSS;
        private System.Windows.Forms.CheckBox chbPHILHEALTH;
        private System.Windows.Forms.CheckBox chbHDMF;
        private System.Windows.Forms.RichTextBox SalarySlip;
    }
}