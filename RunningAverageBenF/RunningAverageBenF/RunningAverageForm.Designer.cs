namespace RunningAverageBenF
{
    partial class frmRunningAverage
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
            this.btnAddToAvg = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblAddToAvg = new System.Windows.Forms.Label();
            this.lblRunningAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddToAvg
            // 
            this.btnAddToAvg.Location = new System.Drawing.Point(172, 74);
            this.btnAddToAvg.Name = "btnAddToAvg";
            this.btnAddToAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAddToAvg.TabIndex = 0;
            this.btnAddToAvg.Text = "Add";
            this.btnAddToAvg.UseVisualStyleBackColor = true;
            this.btnAddToAvg.Click += new System.EventHandler(this.btnAddToAvg_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(46, 76);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 1;
            // 
            // lblAddToAvg
            // 
            this.lblAddToAvg.AutoSize = true;
            this.lblAddToAvg.Location = new System.Drawing.Point(43, 40);
            this.lblAddToAvg.Name = "lblAddToAvg";
            this.lblAddToAvg.Size = new System.Drawing.Size(210, 13);
            this.lblAddToAvg.TabIndex = 2;
            this.lblAddToAvg.Text = "Enter a mark to add to the running average";
            // 
            // lblRunningAverage
            // 
            this.lblRunningAverage.AutoSize = true;
            this.lblRunningAverage.Location = new System.Drawing.Point(43, 165);
            this.lblRunningAverage.Name = "lblRunningAverage";
            this.lblRunningAverage.Size = new System.Drawing.Size(116, 13);
            this.lblRunningAverage.TabIndex = 3;
            this.lblRunningAverage.Text = "The running average is";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRunningAverage);
            this.Controls.Add(this.lblAddToAvg);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnAddToAvg);
            this.Name = "frmRunningAverage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToAvg;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblAddToAvg;
        private System.Windows.Forms.Label lblRunningAverage;
    }
}

