/* Clint MacDonald
 * Date: June 2, 2022
 * Title: Week 5 NETD2202 Demo 2 - Array of Controls
 */

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

namespace _02Week05Demo2
{
    public partial class frmMain : Form
    {
        #region MAIN FUNCTION
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region GLOBAL VARIABLES

        string[] NFLTeams;
        Label[] OutputLabels;
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            NFLTeams = new string[] 
            { "Bills", "Bucaneers", "Dolphins", "Eagles", "49ers", "Saints",
            "Jets", "Raiders", "Cowboys", "Bengles", "Lions", "Packers",
            "Broncos", "Patriots", "Falcons", "SeaHawks", "Jaguars",
            "Texans", "Rams", "Chargers"};

            OutputLabels = new Label[]
            {
                label1, label2, label3, label4, label5, label6, label7, label8
            };


        }

        private void SetLabelText(Label inputLabel, string inputString)
        {
            inputLabel.Text = inputString;
        }

        private int GenerateRandRange()
        {
            Random r = new Random();
            return r.Next();
        }

        private int GenerateRandRange(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int randNum;
            // Loop for each output label 
            foreach (Label lbl in OutputLabels)
            {
                // pick a random number
                randNum = GenerateRandRange(0, NFLTeams.Length - 1);
                // retrieve the team name based on the random number
                // output the team name to the label
                SetLabelText(lbl, NFLTeams[randNum]);
            }
        }
    }
}
