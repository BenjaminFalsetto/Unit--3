namespace FactorialDoWhile
{
    partial class frmFactorialDoWhile
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFactorialNumber = new System.Windows.Forms.TextBox();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(88, 55);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFactorialNumber
            // 
            this.txtFactorialNumber.Location = new System.Drawing.Point(74, 102);
            this.txtFactorialNumber.Name = "txtFactorialNumber";
            this.txtFactorialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFactorialNumber.TabIndex = 1;
            this.txtFactorialNumber.TextChanged += new System.EventHandler(this.txtFactorialNumber_TextChanged);
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(74, 153);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstFactorialNumbers.TabIndex = 2;
            this.lstFactorialNumbers.SelectedIndexChanged += new System.EventHandler(this.lstFactorialNumbers_SelectedIndexChanged);
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 305);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.txtFactorialNumber);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFactorialNumber;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
    }
}

