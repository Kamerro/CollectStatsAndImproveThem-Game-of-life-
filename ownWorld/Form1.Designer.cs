namespace ownWorld
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Strip = new System.Windows.Forms.MenuStrip();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zdupyLolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Strip
            // 
            this.Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem});
            this.Strip.Location = new System.Drawing.Point(0, 0);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(878, 28);
            this.Strip.TabIndex = 0;
            this.Strip.Text = "menuStrip1";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewParameterToolStripMenuItem,
            this.removeParameterToolStripMenuItem,
            this.modifyParameterToolStripMenuItem,
            this.checkParameterToolStripMenuItem,
            this.zdupyLolToolStripMenuItem});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.parametersToolStripMenuItem_DropDownItemClicked);
            // 
            // addNewParameterToolStripMenuItem
            // 
            this.addNewParameterToolStripMenuItem.Name = "addNewParameterToolStripMenuItem";
            this.addNewParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewParameterToolStripMenuItem.Text = "Add new parameter";
            this.addNewParameterToolStripMenuItem.Click += new System.EventHandler(this.addNewParameterToolStripMenuItem_Click);
            // 
            // removeParameterToolStripMenuItem
            // 
            this.removeParameterToolStripMenuItem.Name = "removeParameterToolStripMenuItem";
            this.removeParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeParameterToolStripMenuItem.Text = "Remove parameter";
            // 
            // modifyParameterToolStripMenuItem
            // 
            this.modifyParameterToolStripMenuItem.Name = "modifyParameterToolStripMenuItem";
            this.modifyParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifyParameterToolStripMenuItem.Text = "Modify parameter";
            // 
            // zdupyLolToolStripMenuItem
            // 
            this.zdupyLolToolStripMenuItem.Name = "zdupyLolToolStripMenuItem";
            this.zdupyLolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zdupyLolToolStripMenuItem.Text = "zdupy lol";
            // 
            // checkParameterToolStripMenuItem
            // 
            this.checkParameterToolStripMenuItem.Name = "checkParameterToolStripMenuItem";
            this.checkParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkParameterToolStripMenuItem.Text = "Check parameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 511);
            this.Controls.Add(this.Strip);
            this.MainMenuStrip = this.Strip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Strip;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zdupyLolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkParameterToolStripMenuItem;
    }
}

