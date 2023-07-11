namespace gym_management
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtequipname = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtmusclesused = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerdeliverydate = new System.Windows.Forms.DateTimePicker();
            this.btnvieweq = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(349, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(706, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام تجهیزات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(706, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "توضیحات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(706, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ماهیچه های مورد استفاده";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(706, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "تاریخ تحویل";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(706, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "هزینه محصول";
            // 
            // txtequipname
            // 
            this.txtequipname.Location = new System.Drawing.Point(358, 154);
            this.txtequipname.Name = "txtequipname";
            this.txtequipname.Size = new System.Drawing.Size(289, 22);
            this.txtequipname.TabIndex = 6;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(358, 474);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(289, 22);
            this.txtcost.TabIndex = 7;
            // 
            // txtmusclesused
            // 
            this.txtmusclesused.Location = new System.Drawing.Point(358, 357);
            this.txtmusclesused.Name = "txtmusclesused";
            this.txtmusclesused.Size = new System.Drawing.Size(289, 22);
            this.txtmusclesused.TabIndex = 8;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(270, 205);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(377, 130);
            this.txtdescription.TabIndex = 9;
            this.txtdescription.Text = "";
            // 
            // dateTimePickerdeliverydate
            // 
            this.dateTimePickerdeliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerdeliverydate.Location = new System.Drawing.Point(358, 407);
            this.dateTimePickerdeliverydate.Name = "dateTimePickerdeliverydate";
            this.dateTimePickerdeliverydate.Size = new System.Drawing.Size(289, 22);
            this.dateTimePickerdeliverydate.TabIndex = 10;
            // 
            // btnvieweq
            // 
            this.btnvieweq.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvieweq.Location = new System.Drawing.Point(270, 564);
            this.btnvieweq.Name = "btnvieweq";
            this.btnvieweq.Size = new System.Drawing.Size(136, 30);
            this.btnvieweq.TabIndex = 11;
            this.btnvieweq.Text = "مشاهده تجهیزات";
            this.btnvieweq.UseVisualStyleBackColor = true;
            this.btnvieweq.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(444, 564);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(96, 30);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "تنظیم مجدد";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(572, 564);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 30);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "ثبت";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 640);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnvieweq);
            this.Controls.Add(this.dateTimePickerdeliverydate);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtmusclesused);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtequipname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtequipname;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtmusclesused;
        private System.Windows.Forms.RichTextBox txtdescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerdeliverydate;
        private System.Windows.Forms.Button btnvieweq;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
    }
}