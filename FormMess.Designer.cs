namespace Qforte
{
    partial class FormMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMess));
            this.btApprove = new FontAwesome.Sharp.IconButton();
            this.btDecline = new FontAwesome.Sharp.IconButton();
            this.btDelete = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btApprove
            // 
            this.btApprove.BackColor = System.Drawing.Color.LimeGreen;
            this.btApprove.ForeColor = System.Drawing.Color.White;
            this.btApprove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btApprove.IconColor = System.Drawing.Color.Black;
            this.btApprove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btApprove.Location = new System.Drawing.Point(440, 408);
            this.btApprove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btApprove.Name = "btApprove";
            this.btApprove.Size = new System.Drawing.Size(114, 41);
            this.btApprove.TabIndex = 0;
            this.btApprove.Text = "APPROVE";
            this.btApprove.UseVisualStyleBackColor = false;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click_1);
            // 
            // btDecline
            // 
            this.btDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDecline.ForeColor = System.Drawing.Color.White;
            this.btDecline.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btDecline.IconColor = System.Drawing.Color.Black;
            this.btDecline.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDecline.Location = new System.Drawing.Point(562, 408);
            this.btDecline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDecline.Name = "btDecline";
            this.btDecline.Size = new System.Drawing.Size(114, 41);
            this.btDecline.TabIndex = 1;
            this.btDecline.Text = "DECLINE";
            this.btDecline.UseVisualStyleBackColor = false;
            this.btDecline.Click += new System.EventHandler(this.btDecline_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Crimson;
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btDelete.IconColor = System.Drawing.Color.Black;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.Location = new System.Drawing.Point(684, 408);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 41);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(26, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 294);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Messages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // FormMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDecline);
            this.Controls.Add(this.btApprove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMess";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btApprove;
        private FontAwesome.Sharp.IconButton btDecline;
        private FontAwesome.Sharp.IconButton btDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}