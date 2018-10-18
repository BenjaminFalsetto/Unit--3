namespace ChocolateBoxes
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtNumBoxes = new System.Windows.Forms.TextBox();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.lblRewardAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(25, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(234, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the number of boxes sold:";
            // 
            // txtNumBoxes
            // 
            this.txtNumBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBoxes.Location = new System.Drawing.Point(265, 34);
            this.txtNumBoxes.Name = "txtNumBoxes";
            this.txtNumBoxes.Size = new System.Drawing.Size(100, 26);
            this.txtNumBoxes.TabIndex = 1;
            // 
            // btnGetReward
            // 
            this.btnGetReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(251, 104);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(114, 39);
            this.btnGetReward.TabIndex = 2;
            this.btnGetReward.Text = "Get Reward";
            this.btnGetReward.UseVisualStyleBackColor = true;
            this.btnGetReward.Click += new System.EventHandler(this.btnGetReward_Click);
            // 
            // lblRewardAnswer
            // 
            this.lblRewardAnswer.AutoSize = true;
            this.lblRewardAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardAnswer.Location = new System.Drawing.Point(85, 175);
            this.lblRewardAnswer.Name = "lblRewardAnswer";
            this.lblRewardAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblRewardAnswer.TabIndex = 3;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 229);
            this.Controls.Add(this.lblRewardAnswer);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.txtNumBoxes);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtNumBoxes;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.Label lblRewardAnswer;
    }
}

