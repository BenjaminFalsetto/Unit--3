namespace GuessGameBenF
{
    partial class GuessGameForm
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
            this.lblGuessNum = new System.Windows.Forms.Label();
            this.nudGuess = new System.Windows.Forms.NumericUpDown();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuessNum
            // 
            this.lblGuessNum.AutoSize = true;
            this.lblGuessNum.Font = new System.Drawing.Font("Onky", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessNum.Location = new System.Drawing.Point(12, 94);
            this.lblGuessNum.Name = "lblGuessNum";
            this.lblGuessNum.Size = new System.Drawing.Size(557, 27);
            this.lblGuessNum.TabIndex = 0;
            this.lblGuessNum.Text = "Guess the number between 1 and 10!";
            // 
            // nudGuess
            // 
            this.nudGuess.Location = new System.Drawing.Point(578, 102);
            this.nudGuess.Name = "nudGuess";
            this.nudGuess.Size = new System.Drawing.Size(120, 20);
            this.nudGuess.TabIndex = 1;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Onky", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(12, 229);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(286, 27);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.Text = "Correct! Good job!";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Onky", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(12, 291);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(310, 27);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "Incorrect, try again!";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(330, 166);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 383);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.nudGuess);
            this.Controls.Add(this.lblGuessNum);
            this.Name = "GuessGameForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessNum;
        private System.Windows.Forms.NumericUpDown nudGuess;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Button btnCheck;
    }
}

