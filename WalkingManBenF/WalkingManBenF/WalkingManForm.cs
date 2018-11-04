using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WalkingManBenF
{
    public partial class WalkingManForm : Form
    {
        public WalkingManForm()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            const byte MAX_FRAMES = 10;
            int manInBoxCounter = 1;
            
            //continue the loop while the frame counter has not reached the max amount of frames
            while (manInBoxCounter < MAX_FRAMES + 1)
            {
                if (manInBoxCounter == 1)
                {
                    this.picManInBox.Image = Properties.Resources.walk1;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 2)
                {
                    this.picManInBox.Image = Properties.Resources.walk2;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 3)
                {
                    this.picManInBox.Image = Properties.Resources.walk3;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if(manInBoxCounter == 4)
                {
                    this.picManInBox.Image = Properties.Resources.walk4;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 5)
                {
                    this.picManInBox.Image = Properties.Resources.walk5;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 6)
                {
                    this.picManInBox.Image = Properties.Resources.walk6;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 7)
                {
                    this.picManInBox.Image = Properties.Resources.walk7;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 8)
                {
                    this.picManInBox.Image = Properties.Resources.walk8;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 9)
                {
                    this.picManInBox.Image = Properties.Resources.walk9;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
                else if (manInBoxCounter == 10)
                {
                    this.picManInBox.Image = Properties.Resources.walk10;
                    this.Refresh();
                    manInBoxCounter++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
