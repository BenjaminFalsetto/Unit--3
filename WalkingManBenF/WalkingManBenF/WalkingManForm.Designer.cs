namespace WalkingManBenF
{
    partial class WalkingManForm
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
            this.picManInBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picManInBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picManInBox
            // 
            this.picManInBox.Location = new System.Drawing.Point(42, 138);
            this.picManInBox.Name = "picManInBox";
            this.picManInBox.Size = new System.Drawing.Size(155, 140);
            this.picManInBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManInBox.TabIndex = 0;
            this.picManInBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(82, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // WalkingManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 300);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picManInBox);
            this.Name = "WalkingManForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picManInBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picManInBox;
        private System.Windows.Forms.Button btnStart;
    }
}

