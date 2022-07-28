using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week12_MDI_Menus
{
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        #region Singleton Pattern
        private static frmTemp tempInstance;
        public static frmTemp Instance
        {
            get
            {
                if (tempInstance == null)
                    tempInstance = new frmTemp();

                return tempInstance;
            }
        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            tempInstance = null;
        }

        #endregion

        private void ShowAbout(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmParent frm = (frmParent)this.MdiParent;
            frm.SetStatusText(txtMyTextbox.Text);
        }
    }
}
