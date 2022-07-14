using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week10_MultiFormEditor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        public Editor(int trooperID)
        {
            InitializeComponent();
            TrooperID = trooperID;
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>();
        int TrooperID = 0;
        #endregion

        private void Editor_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;
            if (TrooperID > 0) 
            {
                Trooper foundTrooper = Trooper.FindTrooper(TrooperID);
                PopulateTrooper(foundTrooper);
            } else
            {
                SetDefaults();
            }
            
        }

        private void PopulatePlanets()
        {
            Planets.Add("Alderaan");
            Planets.Add("Bespin");
            Planets.Add("Coruscant");
            Planets.Add("Dagobah");
            Planets.Add("Endor");
            Planets.Add("Geonosis");
            Planets.Add("Hoth");
            Planets.Add("Jakku");
            Planets.Add("Kamino");
            Planets.Add("Mandalore");
            Planets.Add("Mustafar");
            Planets.Add("Naboo");
            Planets.Add("Scarif");
            Planets.Add("Tatooine");
            Planets.Add("Yavin");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // do save stuff
            Trooper trp = new Trooper();
            trp.NickName = txtNickName.Text;
            trp.Unit = txtUnit.Text;
            trp.IsDefective = chkDefective.Checked;
            trp.HairColor = lblHairColour.BackColor;
            trp.EyeColor = lblEyeColour.BackColor;
            trp.Born = dtpBorn.Value;
            trp.HomeWorld = cboPlanets.SelectedValue.ToString();

            if (TrooperID > 0)
            {   // editting
                trp.Designation = TrooperID;
                Trooper foundTrooper = Trooper.FindTrooper(trp.Designation);
                Trooper.troopers.Remove(foundTrooper);
                Trooper.troopers.Add(trp);
            } else
            {   // adding
                Trooper.troopers.Add(trp);
            }

            this.Close();
        }

        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColour.BackColor = colorDialog1.Color;
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColour.BackColor = colorDialog1.Color;
        }

        private void PopulateTrooper(Trooper trp)
        {
            nudDesignation.Value = trp.Designation;
            txtNickName.Text = trp.NickName;
            txtUnit.Text = trp.Unit;
            chkDefective.Checked = trp.IsDefective;
            lblHairColour.BackColor = trp.HairColor;
            lblEyeColour.BackColor = trp.EyeColor;
            dtpBorn.Value = trp.Born;
            cboPlanets.SelectedItem = trp.HomeWorld;
        }
    }
}
