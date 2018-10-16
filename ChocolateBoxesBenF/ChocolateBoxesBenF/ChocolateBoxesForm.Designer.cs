namespace ChocolateBoxesBenF
{
    partial class frmChocolateBoxes
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
            this.lblNumDeliv = new System.Windows.Forms.Label();
            this.txtNumDeliv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumDeliv
            // 
            this.lblNumDeliv.AutoSize = true;
            this.lblNumDeliv.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDeliv.Location = new System.Drawing.Point(-1, 35);
            this.lblNumDeliv.Name = "lblNumDeliv";
            this.lblNumDeliv.Size = new System.Drawing.Size(543, 30);
            this.lblNumDeliv.TabIndex = 0;
            this.lblNumDeliv.Text = "How many boxes of chocolates did you deliver?";
            // 
            // txtNumDeliv
            // 
            this.txtNumDeliv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumDeliv.Location = new System.Drawing.Point(90, 154);
            this.txtNumDeliv.Name = "txtNumDeliv";
            this.txtNumDeliv.Size = new System.Drawing.Size(100, 22);
            this.txtNumDeliv.TabIndex = 1;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 476);
            this.Controls.Add(this.txtNumDeliv);
            this.Controls.Add(this.lblNumDeliv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChocolateBoxes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDeliv;
        private System.Windows.Forms.TextBox txtNumDeliv;
    }
}

