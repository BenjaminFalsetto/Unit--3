/*
     * Created by: Benjamin Falsetto
     * Created on: 2018/10/10
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Guess Game
     * This program takes user input and tells user if their guess was correct or not.
    */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameBenF
{
    public partial class GuessGameForm : Form
    {
        public GuessGameForm()
        {
            InitializeComponent();
            this.lblCorrect.Hide();
            this.lblIncorrect.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declare variables
            Random rnd = new Random();
            int ans = rnd.Next(1, 11);
            int guess = (int)(nudGuess.Value);

            //check user input
<<<<<<< HEAD
            if (guess == ANS)
=======
            if (guess == ans)
>>>>>>> 832173c898f68e5fc93841730371ab40d72e7fae
            {
                this.lblCorrect.Show();
                this.lblIncorrect.Hide();
            }
<<<<<<< HEAD
            if (guess < ANS)
=======
            if (guess > ans)
            {
                this.lblIncorrect.Show();
                this.lblCorrect.Hide();
            }
            if (guess < ans)
>>>>>>> 832173c898f68e5fc93841730371ab40d72e7fae
            {
                this.lblIncorrect.Show();
                this.lblCorrect.Hide();
            }
<<<<<<< HEAD
        }   
=======

        }
>>>>>>> 832173c898f68e5fc93841730371ab40d72e7fae
    }
}   
