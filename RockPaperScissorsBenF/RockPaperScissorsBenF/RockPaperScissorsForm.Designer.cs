namespace RockPaperScissorsBenF
{
    partial class RockPaperScissorsForm
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
            this.grbUserInput = new System.Windows.Forms.GroupBox();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.grbComInput = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbUserInput.SuspendLayout();
            this.grbComInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserInput
            // 
            this.grbUserInput.Controls.Add(this.radUserScissors);
            this.grbUserInput.Controls.Add(this.radUserPaper);
            this.grbUserInput.Controls.Add(this.radUserRock);
            this.grbUserInput.Location = new System.Drawing.Point(41, 55);
            this.grbUserInput.Name = "grbUserInput";
            this.grbUserInput.Size = new System.Drawing.Size(200, 100);
            this.grbUserInput.TabIndex = 0;
            this.grbUserInput.TabStop = false;
            this.grbUserInput.Text = "Player";
            // 
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(19, 20);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 0;
            this.radUserRock.TabStop = true;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Location = new System.Drawing.Point(19, 43);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(53, 17);
            this.radUserPaper.TabIndex = 1;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Location = new System.Drawing.Point(19, 66);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(64, 17);
            this.radUserScissors.TabIndex = 2;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            // 
            // grbComInput
            // 
            this.grbComInput.Controls.Add(this.radioButton1);
            this.grbComInput.Controls.Add(this.radioButton2);
            this.grbComInput.Controls.Add(this.radioButton3);
            this.grbComInput.Enabled = false;
            this.grbComInput.Location = new System.Drawing.Point(41, 205);
            this.grbComInput.Name = "grbComInput";
            this.grbComInput.Size = new System.Drawing.Size(200, 100);
            this.grbComInput.TabIndex = 1;
            this.grbComInput.TabStop = false;
            this.grbComInput.Text = "Computer";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Scissors";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paper";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Rock";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(345, 166);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 27);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 392);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComInput);
            this.Controls.Add(this.grbUserInput);
            this.Name = "RockPaperScissorsForm";
            this.Text = "Rock, Paper, Scissors";
            this.grbUserInput.ResumeLayout(false);
            this.grbUserInput.PerformLayout();
            this.grbComInput.ResumeLayout(false);
            this.grbComInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserInput;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.GroupBox grbComInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnPlay;
    }
}

