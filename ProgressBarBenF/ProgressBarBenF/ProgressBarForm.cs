using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarBenF
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            const int MAX_PROGRESS_BAR_VALUE = 100;
            int progBarVal = 0;

            //increment the progress bar by 1 each time until
            //it has reached its max value
            do
            {
                this.prbProgress.Value = progBarVal;
                progBarVal = progBarVal + 1;
                this.Refresh();
            } while (progBarVal <= MAX_PROGRESS_BAR_VALUE);
        }
    }
}
