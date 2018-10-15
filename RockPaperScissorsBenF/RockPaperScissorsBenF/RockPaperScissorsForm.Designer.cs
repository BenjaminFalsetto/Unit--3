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
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.grbComInput = new System.Windows.Forms.GroupBox();
            this.radComScissors = new System.Windows.Forms.RadioButton();
            this.radComPaper = new System.Windows.Forms.RadioButton();
            this.radComRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblComPoints = new System.Windows.Forms.Label();
            this.lblUserPoints = new System.Windows.Forms.Label();
            this.txtUserPoints = new System.Windows.Forms.TextBox();
            this.txtComPoints = new System.Windows.Forms.TextBox();
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
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(19, 20);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 0;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            // 
            // grbComInput
            // 
            this.grbComInput.Controls.Add(this.radComScissors);
            this.grbComInput.Controls.Add(this.radComPaper);
            this.grbComInput.Controls.Add(this.radComRock);
            this.grbComInput.Enabled = false;
            this.grbComInput.Location = new System.Drawing.Point(41, 205);
            this.grbComInput.Name = "grbComInput";
            this.grbComInput.Size = new System.Drawing.Size(200, 100);
            this.grbComInput.TabIndex = 1;
            this.grbComInput.TabStop = false;
            this.grbComInput.Text = "Computer";
            // 
            // radComScissors
            // 
            this.radComScissors.AutoSize = true;
            this.radComScissors.Location = new System.Drawing.Point(19, 66);
            this.radComScissors.Name = "radComScissors";
            this.radComScissors.Size = new System.Drawing.Size(64, 17);
            this.radComScissors.TabIndex = 2;
            this.radComScissors.TabStop = true;
            this.radComScissors.Text = "Scissors";
            this.radComScissors.UseVisualStyleBackColor = true;
            // 
            // radComPaper
            // 
            this.radComPaper.AutoSize = true;
            this.radComPaper.Location = new System.Drawing.Point(19, 43);
            this.radComPaper.Name = "radComPaper";
            this.radComPaper.Size = new System.Drawing.Size(53, 17);
            this.radComPaper.TabIndex = 1;
            this.radComPaper.TabStop = true;
            this.radComPaper.Text = "Paper";
            this.radComPaper.UseVisualStyleBackColor = true;
            // 
            // radComRock
            // 
            this.radComRock.AutoSize = true;
            this.radComRock.Location = new System.Drawing.Point(19, 20);
            this.radComRock.Name = "radComRock";
            this.radComRock.Size = new System.Drawing.Size(51, 17);
            this.radComRock.TabIndex = 0;
            this.radComRock.TabStop = true;
            this.radComRock.Text = "Rock";
            this.radComRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(218, 335);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(77, 27);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblComPoints
            // 
            this.lblComPoints.AutoSize = true;
            this.lblComPoints.Location = new System.Drawing.Point(293, 205);
            this.lblComPoints.Name = "lblComPoints";
            this.lblComPoints.Size = new System.Drawing.Size(84, 13);
            this.lblComPoints.TabIndex = 4;
            this.lblComPoints.Text = "Computer Points";
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.Location = new System.Drawing.Point(293, 55);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(68, 13);
            this.lblUserPoints.TabIndex = 3;
            this.lblUserPoints.Text = "Player Points";
            // 
            // txtUserPoints
            // 
            this.txtUserPoints.Enabled = false;
            this.txtUserPoints.Location = new System.Drawing.Point(381, 52);
            this.txtUserPoints.Name = "txtUserPoints";
            this.txtUserPoints.Size = new System.Drawing.Size(100, 20);
            this.txtUserPoints.TabIndex = 5;
            this.txtUserPoints.Text = "0";
            // 
            // txtComPoints
            // 
            this.txtComPoints.Enabled = false;
            this.txtComPoints.Location = new System.Drawing.Point(381, 202);
            this.txtComPoints.Name = "txtComPoints";
            this.txtComPoints.Size = new System.Drawing.Size(100, 20);
            this.txtComPoints.TabIndex = 6;
            this.txtComPoints.Text = "0";
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 392);
            this.Controls.Add(this.txtComPoints);
            this.Controls.Add(this.txtUserPoints);
            this.Controls.Add(this.lblComPoints);
            this.Controls.Add(this.lblUserPoints);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserInput;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.GroupBox grbComInput;
        private System.Windows.Forms.RadioButton radComScissors;
        private System.Windows.Forms.RadioButton radComPaper;
        private System.Windows.Forms.RadioButton radComRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblComPoints;
        private System.Windows.Forms.Label lblUserPoints;
        private System.Windows.Forms.TextBox txtUserPoints;
        private System.Windows.Forms.TextBox txtComPoints;
    }
}

