using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week11_FileIO
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
            Trooper.troopers.AddRange(Trooper.GetSampleTroopers());
            UpdateDataGrid();
        }



        #endregion

        #region CUSTOM METHODS

        public void UpdateDataGrid()
        {
            this.DoSelectionChange = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = Trooper.troopers;
            dgvClones.ClearSelection();
            DoSelectionChange = true;
        }
        #endregion

        private void Selection_Changed(object sender, EventArgs e)
        {
            if (DoSelectionChange && dgvClones.SelectedRows.Count > 0)
            {
                //MessageBox.Show(this.dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                int trpID = int.Parse(dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                Editor frmNew = new Editor(trpID);
                frmNew.Show();
                //Trooper foundTrooper = Trooper.FindTrooper(trpID);
                //PopulateTrooper(foundTrooper);
            }
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Editor frmNew = new Editor();
            frmNew.Show();
        }

        private void HeyResetMe(object sender, EventArgs e)
        {
            //MessageBox.Show("Clint was here!!");
            UpdateDataGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Trooper.troopers.Clear();
            UpdateDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Trooper.SaveTroopers(saveFileDialog1.FileName);
                MessageBox.Show("Save Confirmation", "Troopers Saved", MessageBoxButtons.OK);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Trooper.troopers.Clear();
                Trooper.LoadFromCSV(openFileDialog1.FileName);
                UpdateDataGrid();

            }
        }
    }
}
