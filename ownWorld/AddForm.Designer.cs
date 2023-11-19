namespace ownWorld
{
    partial class AddForm
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
            this.newFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFieldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newFieldToolStripMenuItem
            // 
            this.newFieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asDescriptionToolStripMenuItem,
            this.asValueToolStripMenuItem});
            this.newFieldToolStripMenuItem.Name = "newFieldToolStripMenuItem";
            this.newFieldToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.newFieldToolStripMenuItem.Text = "New field";
            // 
            // asDescriptionToolStripMenuItem
            // 
            this.asDescriptionToolStripMenuItem.Name = "asDescriptionToolStripMenuItem";
            this.asDescriptionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asDescriptionToolStripMenuItem.Text = "As description";
            this.asDescriptionToolStripMenuItem.Click += new System.EventHandler(this.asDescriptionToolStripMenuItem_Click);
            // 
            // asValueToolStripMenuItem
            // 
            this.asValueToolStripMenuItem.Name = "asValueToolStripMenuItem";
            this.asValueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asValueToolStripMenuItem.Text = "As value";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 415);
            this.panel1.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asValueToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}