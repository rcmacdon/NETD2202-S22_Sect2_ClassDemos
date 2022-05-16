using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week03DemoA___MyAdder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EVENT: Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// EVENT: Resets the entire form back to its default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtX.Text = "";
            //txtX.Text = string.Empty;
            txtX.Clear();  // most efficient 
            txtY.Clear();
            lblAnswer.Text = "-";
            txtX.Focus();
        }

        /// <summary>
        /// EVENT:   Performs the actual addition of the values in X and Y textboxes and
        ///          places the answer in the answer label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numX, numY, answer;

            if (int.TryParse(txtX.Text, out numX))
            {
                // it worked
                if (int.TryParse(txtY.Text, out numY))
                {
                    // it also worked
                    answer = numX + numY;
                    lblAnswer.Text = answer.ToString();
                }
                else
                {
                    MessageBox.Show("The value of Y is not an integer!");
                }
            }
            else
            {
                MessageBox.Show("The value of X is not an integer!");
            }
        }
    }
}
