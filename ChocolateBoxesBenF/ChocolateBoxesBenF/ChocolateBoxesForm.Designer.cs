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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChocolateBoxes));
            this.lblNumDeliv = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.nudBoxDelivered = new System.Windows.Forms.NumericUpDown();
            this.lblHereYouGo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumDeliv
            // 
            this.lblNumDeliv.AutoSize = true;
            this.lblNumDeliv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDeliv.Location = new System.Drawing.Point(-1, 28);
            this.lblNumDeliv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumDeliv.Name = "lblNumDeliv";
            this.lblNumDeliv.Size = new System.Drawing.Size(472, 26);
            this.lblNumDeliv.TabIndex = 0;
            this.lblNumDeliv.Text = "How many boxes of chocolates did you deliver?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(59, 182);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // nudBoxDelivered
            // 
            this.nudBoxDelivered.Location = new System.Drawing.Point(59, 104);
            this.nudBoxDelivered.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBoxDelivered.Name = "nudBoxDelivered";
            this.nudBoxDelivered.Size = new System.Drawing.Size(120, 20);
            this.nudBoxDelivered.TabIndex = 3;
            this.nudBoxDelivered.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHereYouGo
            // 
            this.lblHereYouGo.AutoSize = true;
            this.lblHereYouGo.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHereYouGo.Location = new System.Drawing.Point(12, 258);
            this.lblHereYouGo.Name = "lblHereYouGo";
            this.lblHereYouGo.Size = new System.Drawing.Size(321, 56);
            this.lblHereYouGo.TabIndex = 4;
            this.lblHereYouGo.Text = "Here you go. Its a label.\r\nGood job boy scout.";
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 387);
            this.Controls.Add(this.lblHereYouGo);
            this.Controls.Add(this.nudBoxDelivered);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNumDeliv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes Benjamin Falsetto";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDeliv;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown nudBoxDelivered;
        private System.Windows.Forms.Label lblHereYouGo;
    }
}

