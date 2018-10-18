/*
 * Created by: Ms Raffin
 * Created on: 19-Mar-2013
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program displays the type of prize sold depending on the number of boxes sold input by the user.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChocolateBoxes
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            // declare local variables
            int numBoxes;

            // get number of boxes sold from user
            numBoxes = int.Parse(txtNumBoxes.Text);

            // determine the type of reward using a nested if statement
            if (numBoxes > 20)
            {
                lblRewardAnswer.Text = "The reward is a Prize.";
            }
            else
            {
                if (numBoxes < 10)
                {
                    lblRewardAnswer.Text = "The reward is Honorable Mention.";
                }
                else
                {
                    lblRewardAnswer.Text = "The reward is a Small Prize.";
                }
            }           
        }
    }
}
