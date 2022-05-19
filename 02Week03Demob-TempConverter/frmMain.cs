/*
 * Name: Clint MacDonald
 * StudentID: 100######
 * Date: May 19, 2022
 * Title: Week 03 Demo B - Temperature Converter
 * GitHub: 
 * 
 * */

#region Using Section
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace _02Week03Demob_TempConverter
{
    public partial class frmMain : Form
    {
        #region Constants and Global Variables
        const Double convertMultiplier = 1.8;
            const Double convertAdder = 32;
        #endregion

        #region Form Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Events

        /// <summary>
        /// Exit the application after a confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to quit?", 
                        "Exit confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        /// <summary>
        /// executes the SetDefaults method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

       /// <summary>
       /// Perform the actual calculation and data validation
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void btnConvert_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                Double inputValue, outputValue;
                inputValue = Double.Parse(txtInputTemp.Text);

                if (radC.Checked)
                {
                    lblUnits.Text = "F";
                    outputValue = inputValue * convertMultiplier + convertAdder; ;
                    lblAnswer.Text = outputValue.ToString();
                }
                else
                {
                    lblUnits.Text = "C";
                    outputValue = (inputValue - convertAdder) / convertMultiplier;
                    lblAnswer.Text = outputValue.ToString();
                }
            }
        }

        #endregion

        #region Custom Functions

        /// <summary>
        /// Resets the entire to its initial default values
        /// </summary>
        private void SetDefaults()
        {
            txtInputTemp.Clear();
            radC.Checked = false;
            radF.Checked = false;
            lblAnswer.Text = string.Empty;
            lblUnits.Text = "-";
            txtInputTemp.Focus();
        }

        private Boolean IsInputValid()
        {
            Boolean retVal = true;

            // test if input is a decimal value
            Double inputValue;
            retVal = Double.TryParse(txtInputTemp.Text, out inputValue);
            if (!retVal) MessageBox.Show("The input value was not a valid decimal number!");

            // test that either C or F is chosen
            if (!(radC.Checked || radF.Checked))
            {
                retVal = false;
                MessageBox.Show("You must select one of the input unit values");
            }

            return retVal;
        }

        #endregion

 
    }
}
