/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/05
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program takes user input in the form of a number and calculates the factorial of that number
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

namespace FactorialDoWhile
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double factorialAnswer, factorialNumber;
            int factorialCounter;

            //clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            //set final answer to 1
            factorialAnswer = 1;

            //get the number from the user
            factorialNumber = Convert.ToDouble(this.txtFactorialNumber.Text);

            //set the counter to 0
            factorialCounter = 0;

            //multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                //increment the counter by 1
                factorialCounter++;

                //list the counter number in the listbox for the user to see
                lstFactorialNumbers.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialCounter * factorialAnswer;

            } while (factorialCounter < factorialNumber);

            //add the answer to its label and display the label
            lblFactorialAnswer.Text = (factorialNumber + "! = " + factorialAnswer);
            lblFactorialAnswer.Show();
        }

        private void txtFactorialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstFactorialNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
