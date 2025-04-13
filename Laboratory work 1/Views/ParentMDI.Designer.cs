namespace Laboratory_work_1
{
    partial class FormContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запитанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретичніЗапитанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практичніПитанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відповідьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запитанняToolStripMenuItem,
            this.відповідьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запитанняToolStripMenuItem
            // 
            this.запитанняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теоретичніЗапитанняToolStripMenuItem,
            this.практичніПитанняToolStripMenuItem});
            this.запитанняToolStripMenuItem.Name = "запитанняToolStripMenuItem";
            this.запитанняToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.запитанняToolStripMenuItem.Text = "Запитання";
            // 
            // теоретичніЗапитанняToolStripMenuItem
            // 
            this.теоретичніЗапитанняToolStripMenuItem.Name = "теоретичніЗапитанняToolStripMenuItem";
            this.теоретичніЗапитанняToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.теоретичніЗапитанняToolStripMenuItem.Text = "Теоретичні питання";
            this.теоретичніЗапитанняToolStripMenuItem.Click += new System.EventHandler(this.теоретичніЗапитанняToolStripMenuItem_Click);
            // 
            // практичніПитанняToolStripMenuItem
            // 
            this.практичніПитанняToolStripMenuItem.Name = "практичніПитанняToolStripMenuItem";
            this.практичніПитанняToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.практичніПитанняToolStripMenuItem.Text = "Практичні питання";
            this.практичніПитанняToolStripMenuItem.Click += new System.EventHandler(this.практичніПитанняToolStripMenuItem_Click);
            // 
            // відповідьToolStripMenuItem
            // 
            this.відповідьToolStripMenuItem.Name = "відповідьToolStripMenuItem";
            this.відповідьToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.відповідьToolStripMenuItem.Text = "Відповідь";
            // 
            // formContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formContainer";
            this.Text = "Залік з теоретичної механіки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запитанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоретичніЗапитанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практичніПитанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відповідьToolStripMenuItem;
    }
}

