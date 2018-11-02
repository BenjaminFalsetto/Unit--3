namespace ForEachControlObjBenF
{
    partial class frmForEachControlObj
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lblIAmLabel = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.Location = new System.Drawing.Point(204, 104);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblIAmLabel
            // 
            this.lblIAmLabel.AutoSize = true;
            this.lblIAmLabel.Location = new System.Drawing.Point(186, 168);
            this.lblIAmLabel.Name = "lblIAmLabel";
            this.lblIAmLabel.Size = new System.Drawing.Size(110, 13);
            this.lblIAmLabel.TabIndex = 1;
            this.lblIAmLabel.Text = "I am a label. Click me!";
            this.lblIAmLabel.Click += new System.EventHandler(this.lblIAmLabel_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(482, 24);
            this.mnuMenu.TabIndex = 2;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniReset,
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniReset
            // 
            this.mniReset.Name = "mniReset";
            this.mniReset.Size = new System.Drawing.Size(152, 22);
            this.mniReset.Text = "Reset";
            this.mniReset.Click += new System.EventHandler(this.mniReset_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmForEachControlObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 380);
            this.Controls.Add(this.lblIAmLabel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmForEachControlObj";
            this.Text = "For Each With Control Objects Benjamin Falsetto";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblIAmLabel;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniReset;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

