/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/10/16
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows a user to play rock, paper, scissors against the computer.
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

namespace RockPaperScissorsBenF
{
    public partial class RockPaperScissorsForm : Form
    {
        //declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public RockPaperScissorsForm()
        {
            InitializeComponent();
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            int userChoice, computerChoice, userPoints = int.Parse(txtUserPoints.Text), comPoints = int.Parse(txtComPoints.Text);
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get user guess, if nothing is selected, disable play button
            if (radUserRock.Checked == true)
            {
                userChoice = ROCK;
            }
            else if (radUserPaper.Checked == true)
            {
                userChoice = PAPER;
            }
            else if (radUserScissors.Checked == true)
            {
                userChoice = SCISSORS;
            }
            else
            {
                userChoice = 0;
            }

            //randomly generate a number between 1 and 3
            //representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //set the radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radComRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComPaper.Checked = true;
            }
            else
            {
                this.radComScissors.Checked = true;
            }

            //compaare userChoice with computerChoice to see who won
            if (userChoice == ROCK)
            {
                if (computerChoice == ROCK)
                {
                    MessageBox.Show("Tie game");
                }
                else if (computerChoice == PAPER)
                {
                    MessageBox.Show("Computer wins");
                    comPoints++;
                    txtComPoints.Text = comPoints.ToString();
                }
                else
                {
                    MessageBox.Show("Player wins!");
                    userPoints++;
                    txtUserPoints.Text = userPoints.ToString();
                }
            }

            else if (userChoice == PAPER)
            {
                if (computerChoice == PAPER)
                {
                    MessageBox.Show("Tie game");
                }
                else if (computerChoice == SCISSORS)
                {
                    MessageBox.Show("Computer wins");
                    comPoints++;
                    txtComPoints.Text = comPoints.ToString();
                }
                else
                {
                    MessageBox.Show("Player wins!");
                    userPoints++;
                    txtUserPoints.Text = userPoints.ToString();
                }
            }
            else if (userChoice == SCISSORS)
            {
                if (computerChoice == SCISSORS)
                {
                    MessageBox.Show("Tie game");
                }
                else if (computerChoice == ROCK)
                {
                    MessageBox.Show("Computer wins");
                    comPoints++;
                    txtComPoints.Text = comPoints.ToString();
                }
                else
                {
                    MessageBox.Show("Player wins!");
                    userPoints++;
                    txtUserPoints.Text = userPoints.ToString();
                }
            }
            else
            {
                MessageBox.Show("No player input. Computer wins by default");
            }
        }
    }
}
