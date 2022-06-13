using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week7Demo1_DroidClass
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void something()
        {
            Droid drd = new Droid();
            drd.Designation = "R2D2";
            drd.Owner = "Obiwon Kenobi";
            drd.IsInService = true;
            drd.PrimaryColor = Color.White;
            drd.SecondaryColor = Color.Blue;

            Droid drd2 = new Droid("C3P0", "Anakin Skywalker", true, Color.Gold, Color.Black);

            // Anakin goes all dark on us and C3P0 goes to Luke
            drd2.SellDroid("Luke Skywalker", true);

            Droid foundDroid = Droid.FindDroid("R2D2");

        }

    }
}
