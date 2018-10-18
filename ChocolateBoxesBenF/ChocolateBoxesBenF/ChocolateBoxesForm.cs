using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesBenF
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare local variables
            int boxDelivered;

            //get number of boxes sold by user
            boxDelivered = (int)(nudBoxDelivered.Value);


        }
    }
}
