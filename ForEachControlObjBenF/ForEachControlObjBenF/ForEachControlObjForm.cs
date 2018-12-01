/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/10
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the colour of objects on the form when certain objects are clicked.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachControlObjBenF
{
    public partial class frmForEachControlObj : Form
    {
        public frmForEachControlObj()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //loop through each object on the form and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                //if the object is a label, make it purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
                if (aControlObject.GetType() == typeof(MenuStrip))
                {
                    aControlObject.BackColor = Color.Transparent;
                }
            }
        }

        private void lblIAmLabel_Click(object sender, EventArgs e)
        {
            //loop through each object on the form and make it Red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                //if the object is a button, make it blue
                if (aControlObject.GetType() == typeof(Button))
                {
                    aControlObject.BackColor = Color.Blue;
                }
                if (aControlObject.GetType() == typeof(MenuStrip))
                {
                    aControlObject.BackColor = Color.Transparent;
                }
            }
        }

        private void mniReset_Click(object sender, EventArgs e)
        {
            //loop through each object on the form and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Transparent;
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
