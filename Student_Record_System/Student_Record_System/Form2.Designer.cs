namespace Student_Record_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.manageListToolStripMenuItem,
            this.sTATICToolStripMenuItem,
            this.sTUDENTLISTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.studentToolStripMenuItem.Text = "ADD STUDENT";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // manageListToolStripMenuItem
            // 
            this.manageListToolStripMenuItem.Name = "manageListToolStripMenuItem";
            this.manageListToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.manageListToolStripMenuItem.Text = "MANAGE LIST";
            this.manageListToolStripMenuItem.Click += new System.EventHandler(this.manageListToolStripMenuItem_Click);
            // 
            // sTATICToolStripMenuItem
            // 
            this.sTATICToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sTATICToolStripMenuItem.Name = "sTATICToolStripMenuItem";
            this.sTATICToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.sTATICToolStripMenuItem.Text = "STATIC";
            // 
            // sTUDENTLISTToolStripMenuItem
            // 
            this.sTUDENTLISTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sTUDENTLISTToolStripMenuItem.Name = "sTUDENTLISTToolStripMenuItem";
            this.sTUDENTLISTToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.sTUDENTLISTToolStripMenuItem.Text = "STUDENT LIST";
            this.sTUDENTLISTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTLISTToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(617, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Record_System.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(733, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTATICToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}