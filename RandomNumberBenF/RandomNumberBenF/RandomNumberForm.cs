using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberBenF
{
    public partial class frmRandomNumber : Form
    {
        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //deckare constants and variables
            const int MAX_NUM = 10;
            const int MIN_NUM = 1;
            int randNum;
            Random randomNumberGenerator = new Random();


        }
    }
}
