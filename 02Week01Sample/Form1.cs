using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week01Sample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //todo: hey I need to do something here
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked Exit");
            Application.Exit();
        }
    }
}
