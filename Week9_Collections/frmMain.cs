using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8_Collections
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>();
        Boolean DoSelectionChange = false;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            cboPlanets.DataSource = Planets;

            Trooper.troopers.AddRange(Trooper.GetSampleTroopers());
            UpdateDataGrid();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region CUSTOM METHODS
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

        private void UpdateDataGrid()
        {
            DoSelectionChange = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = Trooper.troopers;
            dgvClones.ClearSelection();
            DoSelectionChange = true;
        }
        #endregion

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Trooper trp = new Trooper();
            trp.NickName = txtNickName.Text;
            trp.Unit = txtUnit.Text;
            trp.IsDefective = chkDefective.Checked;
            trp.HairColor = lblHairColour.BackColor;
            trp.EyeColor = lblEyeColour.BackColor;
            trp.Born = dtpBorn.Value;
            trp.HomeWorld = cboPlanets.SelectedValue.ToString();

            if ((Int32)nudDesignation.Value == 0)
            {
                // adding NEW trooper
                Trooper.troopers.Add(trp);

            } else
            {
                // editting existing trooper
                trp.Designation = (Int32)nudDesignation.Value;

                Trooper foundTrooper = Trooper.FindTrooper(trp.Designation);
                Trooper.troopers.Remove(foundTrooper);
                Trooper.troopers.Add(trp);
            } 

            UpdateDataGrid();
        }

        private void Selection_Changed(object sender, EventArgs e)
        {
            if (DoSelectionChange && dgvClones.SelectedRows.Count > 0)
            {
                //MessageBox.Show(this.dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                int trpID = int.Parse(dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                Trooper foundTrooper = Trooper.FindTrooper(trpID);
                PopulateTrooper(foundTrooper);
            }
            
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
