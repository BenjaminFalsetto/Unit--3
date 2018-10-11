/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/10/11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program generates a random number and displays it to the user when a button is clicked
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

namespace RandomNumberBenF
{
    public partial class frmRandomNumber : Form
    {
        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //deckare constants and variables
            const int MAX_NUM = 10;
            const int MIN_NUM = 1;
            int randNum;
            Random randomNumberGenerator = new Random();

            //get the random number
            randNum = randomNumberGenerator.Next(MIN_NUM, MAX_NUM+1);

            //display the number to the user
            MessageBox.Show("Your number is " + randNum);

        }
    }
}
