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

            //loop through the letters from 1-10
            for (firstNumber = 65; firstNumber <= 90; firstNumber++)
            {
                for(secondNumber = 97; secondNumber <= 122; secondNumber++)
                {
                    firstLet = char.ConvertFromUtf32(firstNumber);
                    secondLet = char.ConvertFromUtf32(secondNumber);
                    this.lstLetters.Items.Add(firstLet + " -> " + secondLet);
                }
            }
        }
    }
}
