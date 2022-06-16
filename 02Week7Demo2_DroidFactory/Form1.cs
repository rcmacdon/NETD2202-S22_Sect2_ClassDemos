/* -----------------------
 * Author: Clint MacDonald
 * Date: June 2021
 * Title: Droid Factory - Class Example 1
 * ----------------------- */

#region USING
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

namespace W7_Demo_Classes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaults();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = lblPrimaryColour.BackColor;
            colorDialogMain.ShowDialog();
            lblPrimaryColour.BackColor = colorDialogMain.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = lblSecondaryColour.BackColor;
            colorDialogMain.ShowDialog();
            lblSecondaryColour.BackColor = colorDialogMain.Color;
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lboxDroids.SelectedItems.Count > 0)
            {
                string droidDesig = lboxDroids.SelectedItem.ToString();
                Droid foundDroid = Droid.FindDroid(droidDesig);
                lblDetailsDesignation.Text = foundDroid.Designation;
                lblDetailsOwner.Text = foundDroid.Owner;
                chkDetailsInService.Checked = foundDroid.IsInService;
                lblDetailsPrimaryColour.BackColor = foundDroid.PrimaryColor;
                lblDetailsSecondaryColour.BackColor = foundDroid.SecondaryColor;

            }
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            Droid drd = new Droid(txtDesignation.Text, txtOwner.Text, chkInService.Checked, 
                    lblPrimaryColour.BackColor, lblSecondaryColour.BackColor);
            Droid.droids.Add(drd);
            //Droid.droids.Add(new Droid(txtDesignation.Text, txtOwner.Text, chkInService.Checked, 
            //             lblPrimaryColour.BackColor, lblSecondaryColour.BackColor);

            UpdateListBox();

            SetDefaults();
        }
        #endregion

        #region Custom UI Functions and Methods
        private void SetDefaults()
        {
            txtDesignation.Clear();
            txtOwner.Clear();
            chkInService.Checked = false;
            lblPrimaryColour.BackColor = Color.Gray;
            lblSecondaryColour.BackColor = Color.Gray;
        }

        private void UpdateListBox()
        {
            lboxDroids.Items.Clear();
            foreach (Droid droid in Droid.droids)
            {
                lboxDroids.Items.Add(droid.Designation);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Droid.CreateTestDroids();
            UpdateListBox();
        }
    }
}
