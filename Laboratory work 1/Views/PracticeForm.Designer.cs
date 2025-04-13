namespace Laboratory_work_1
{
    partial class PracticeForm
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
            this.Practice_groupBox = new System.Windows.Forms.GroupBox();
            this.C_rb = new System.Windows.Forms.RadioButton();
            this.B_rb = new System.Windows.Forms.RadioButton();
            this.A_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.New_pictureBox = new System.Windows.Forms.PictureBox();
            this.Save_pictureBox = new System.Windows.Forms.PictureBox();
            this.Practice_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Practice_groupBox
            // 
            this.Practice_groupBox.Controls.Add(this.C_rb);
            this.Practice_groupBox.Controls.Add(this.B_rb);
            this.Practice_groupBox.Controls.Add(this.A_rb);
            this.Practice_groupBox.Controls.Add(this.label1);
            this.Practice_groupBox.Controls.Add(this.pictureBox1);
            this.Practice_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practice_groupBox.Location = new System.Drawing.Point(65, 106);
            this.Practice_groupBox.Name = "Practice_groupBox";
            this.Practice_groupBox.Size = new System.Drawing.Size(735, 720);
            this.Practice_groupBox.TabIndex = 0;
            this.Practice_groupBox.TabStop = false;
            this.Practice_groupBox.Text = "Практичне питання №1";
            // 
            // C_rb
            // 
            this.C_rb.AutoSize = true;
            this.C_rb.Location = new System.Drawing.Point(61, 626);
            this.C_rb.Name = "C_rb";
            this.C_rb.Size = new System.Drawing.Size(453, 41);
            this.C_rb.TabIndex = 4;
            this.C_rb.TabStop = true;
            this.C_rb.Text = "Закон всесвітнього тяготіння";
            this.C_rb.UseVisualStyleBackColor = true;
            // 
            // B_rb
            // 
            this.B_rb.AutoSize = true;
            this.B_rb.Location = new System.Drawing.Point(61, 570);
            this.B_rb.Name = "B_rb";
            this.B_rb.Size = new System.Drawing.Size(411, 41);
            this.B_rb.TabIndex = 3;
            this.B_rb.TabStop = true;
            this.B_rb.Text = "Закон збереження енергії";
            this.B_rb.UseVisualStyleBackColor = true;
            // 
            // A_rb
            // 
            this.A_rb.AutoSize = true;
            this.A_rb.Location = new System.Drawing.Point(61, 514);
            this.A_rb.Name = "A_rb";
            this.A_rb.Size = new System.Drawing.Size(441, 41);
            this.A_rb.TabIndex = 2;
            this.A_rb.TabStop = true;
            this.A_rb.Text = "Закон збереження імпульсу";
            this.A_rb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Який закон зображено на малюнку?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory_work_1.Properties.Resources.PH53729_2;
            this.pictureBox1.Location = new System.Drawing.Point(61, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // New_pictureBox
            // 
            this.New_pictureBox.Image = global::Laboratory_work_1.Properties.Resources._new;
            this.New_pictureBox.Location = new System.Drawing.Point(65, 30);
            this.New_pictureBox.Name = "New_pictureBox";
            this.New_pictureBox.Size = new System.Drawing.Size(48, 50);
            this.New_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.New_pictureBox.TabIndex = 1;
            this.New_pictureBox.TabStop = false;
            this.New_pictureBox.Click += new System.EventHandler(this.New_pictureBox_Click);
            // 
            // Save_pictureBox
            // 
            this.Save_pictureBox.Image = global::Laboratory_work_1.Properties.Resources.save;
            this.Save_pictureBox.Location = new System.Drawing.Point(134, 30);
            this.Save_pictureBox.Name = "Save_pictureBox";
            this.Save_pictureBox.Size = new System.Drawing.Size(61, 50);
            this.Save_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Save_pictureBox.TabIndex = 2;
            this.Save_pictureBox.TabStop = false;
            this.Save_pictureBox.Click += new System.EventHandler(this.Save_pictureBox_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 890);
            this.Controls.Add(this.Save_pictureBox);
            this.Controls.Add(this.New_pictureBox);
            this.Controls.Add(this.Practice_groupBox);
            this.Name = "PracticeForm";
            this.Text = "PracticeForm";
            this.Shown += new System.EventHandler(this.PracticeForm_Shown);
            this.Practice_groupBox.ResumeLayout(false);
            this.Practice_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.New_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Practice_groupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton C_rb;
        private System.Windows.Forms.RadioButton B_rb;
        private System.Windows.Forms.RadioButton A_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox New_pictureBox;
        private System.Windows.Forms.PictureBox Save_pictureBox;
    }
}