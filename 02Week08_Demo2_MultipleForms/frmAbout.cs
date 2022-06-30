using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week08_Demo2_MultipleForms
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        public frmAbout(String inputString)
        {
            InitializeComponent();

            txtInput.Text = inputString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
