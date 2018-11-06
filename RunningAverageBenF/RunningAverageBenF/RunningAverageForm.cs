using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageBenF
{
    public partial class frmRunningAverage : Form
    {
        double numMarks = 0, average = 0, total = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnAddToAvg_Click(object sender, EventArgs e)
        {
            double mark = 0;

            mark = double.Parse(txtMark.Text);
            if (mark > 0 && mark < 100)
            {
                total = total + mark;
                numMarks++;
                average = total / numMarks;
                lblRunningAverage.Text = ("Running average = " + average);
            }
            else if (mark == -1)
            {
                MessageBox.Show("The final average is " + average + "%");
                txtMark.Enabled = false;
                btnAddToAvg.Enabled = false;
                lblRunningAverage.Text = ("The final average is " + average + "%");
            }
            else
            {
                MessageBox.Show("Please enter a mark between 1 and 100 or enter -1 to end the program");
            }
        }
    }
}
