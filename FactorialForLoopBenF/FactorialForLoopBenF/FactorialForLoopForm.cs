/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial with for loop
 * This program takes a user value and calculates the factorial of that
 * number and displays all the numbers up until that number
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

namespace FactorialForLoopBenF
{
    public partial class frmFactorialForLoop : Form
    {
        public frmFactorialForLoop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double userVal, factorialAns = 1;
            int counter;

            //clear the listbox
            this.lstNumbers.Items.Clear();

            //get the user value
            userVal = Convert.ToDouble(txtUserVal.Text);

            //loop through all the numbers up until the userVal
            for (counter = 1; counter <= userVal; counter++)
            {
                //add the current value to the listbox
                lstNumbers.Items.Add(counter);

                //calculate the answer
                factorialAns = factorialAns * counter;
            }

            //display the answer to the user
            MessageBox.Show(userVal + "! = " + factorialAns);
        }
    }
}
