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

            }
        }
    }
}
