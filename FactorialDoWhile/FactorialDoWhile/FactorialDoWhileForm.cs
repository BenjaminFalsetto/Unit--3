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
            this.lstFactorialNumbers.ClearSelected();

            //set final answer to 1
            factorialAnswer = 1;

            //get the number from the user

        }

        private void txtFactorialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstFactorialNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
