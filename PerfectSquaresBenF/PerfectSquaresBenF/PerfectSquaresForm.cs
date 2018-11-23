/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect squares with while loop
 * This program takes a value and displays all the perfect squares up until and/or including that number
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

namespace PerfectSquaresBenF
{
    public partial class PerfectSquaresForm : Form
    {
        public PerfectSquaresForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //deckare local variables               
            int endingValue;
            int value;
            Double rootAsDouble;
            int rootAsInt;

            //set the initial values
            value = 1;

            //clear the listbox
            lstSquares.Items.Clear();

            //get the user's end value from the numeric up down
            endingValue = Convert.ToInt32(this.nudEndVal.Value);

            //continue stating any perfect squares between value and the user's end value
            while (value <= endingValue)
            {
                //take the square root of the value
                rootAsDouble = Math.Sqrt(value);

                //convert the double to an integer
                rootAsInt = Convert.ToInt32(rootAsDouble);

                if (rootAsInt == rootAsDouble)
                {
                    this.lstSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value++;
            }
        }
    }
}
