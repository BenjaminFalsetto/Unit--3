/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program displays 1 uppercase letter (in order) then every lowwecase letter
 * to follow, and loops through each uppercase letter
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

namespace NestedLoopsBenF
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber;
            string firstLet, secondLet;

            //clear the listbox
            this.lstLetters.Items.Clear();

            //loop through the letters A-Z
            for (firstNumber = 65; firstNumber <= 90; firstNumber++)
            {
                //loop through the letters from a-z
                for (secondNumber = 97; secondNumber <= 122; secondNumber++)
                {
                    //convert the value of the first number to its uppercase letter 
                    firstLet = char.ConvertFromUtf32(firstNumber);

                    //convert the value of the second letter to its lowercase letter
                    secondLet = char.ConvertFromUtf32(secondNumber);

                    //display the current letters in the listbox
                    this.lstLetters.Items.Add(firstLet + " -> " + secondLet);
                }
            }
        }
    }
}
