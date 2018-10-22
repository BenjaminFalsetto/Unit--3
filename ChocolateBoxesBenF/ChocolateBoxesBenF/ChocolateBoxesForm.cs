/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/10/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program accepts an input in the form of how many boxes were delivered and then gives you a prize based on it.
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

namespace ChocolateBoxesBenF
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            this.lblHereYouGo.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare local variables
            int boxDelivered;

            //get number of boxes sold by user
            boxDelivered = (int)(nudBoxDelivered.Value);

            //determine reward
            if (boxDelivered > 20)
            {
                lblHereYouGo.Text = "Here you go. A prize. \nGood job boy scout.";
                lblHereYouGo.Show();
                nudBoxDelivered.Value = 1;
            }
            else
            {
                if (boxDelivered < 10)
                {
                    lblHereYouGo.Text = "Here you go. Honourable Mention. \nEveryone's a winner.";
                    lblHereYouGo.Show();
                    nudBoxDelivered.Value = 1;
                }
                else
                {
                    lblHereYouGo.Text = "Here you go. A small prize.";
                    lblHereYouGo.Show();
                    nudBoxDelivered.Value = 1;
                }
            }
        }
    }
}
