using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsBenF
{
    public partial class RockPaperScissorsForm : Form
    {
        //declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
        public RockPaperScissorsForm()
        {
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare constants
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get user guess

        }
    }
}
