using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeBenF
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local constants and variables
            const int MIN_NUMBER = 65, MAX_NUMBER = 90;
            int charCounter;
            string unicodeChar;

            //clear the listbox
            lstCharacters.Items.Clear();

            for (charCounter = MIN_NUMBER; charCounter <= MAX_NUMBER; charCounter++)
            {
                unicodeChar = Char.ConvertFromUtf32(charCounter);
                lstCharacters.Items.Add(unicodeChar +" -> " + charCounter);
            }
        }
    }
}
