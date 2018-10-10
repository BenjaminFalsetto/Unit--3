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
            int ANS = rnd.Next(1, 11);
            int guess = (int)(nudGuess.Value);

            //check user input
            {
                if (guess == ANS) ;
                this.lblCorrect.Show();
            }
            
            else

        }   
    }
}
