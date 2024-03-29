﻿#region Header
/* Name: Clint MacDonald
 * Date: June 9, 2022
 * Title: Week 6 Demo 2 Color Swatch Picker
 */
#endregion
#region Using
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

namespace _02Week6Demo2_ColorSwatches
{
    public partial class Form1 : Form
    {
        #region Main Function
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variables
        const int MinDimSize = 3;
        const int MaxDimSize = 8;
        const int DefDimSize = 5;

        const int BlockSize = 80;
        const int GapSize = 5;

        const int StartingYPos = 50;
        const int StartingXPos = 50;

        Label[,] colors;
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            InitialSetup();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            ClearLabels();
            CreateSwatches(Convert.ToInt32(nudDimSize.Value));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLabels();
        }

        private void LabelClicker(object sender, EventArgs e)
        {
            SetColor((Label)Convert.ChangeType(sender, typeof(Label)));


        }

        #endregion

        #region Custom Methods
        private void InitialSetup()
        {
            colors = new Label[MaxDimSize, MaxDimSize];
            nudDimSize.Value = DefDimSize;
            nudDimSize.Minimum = MinDimSize;
            nudDimSize.Maximum = MaxDimSize;
        }

        private void CreateSwatches(int dimSize)
        {
            this.Height = 4 * StartingYPos + dimSize * (BlockSize + GapSize) ;
            this.Width = this.Height;
            for (int r = 0; r < dimSize; r++)
            {
                for (int c = 0; c < dimSize; c++)
                {
                    colors[r, c] = new Label();
                    colors[r, c].Click += new System.EventHandler(this.LabelClicker);

                    colors[r, c].Name = "label" + r.ToString() + c.ToString();
                    colors[r, c].Top = StartingYPos + r * (BlockSize + GapSize);
                    colors[r, c].Left = StartingXPos + c * (BlockSize + GapSize);
                    colors[r, c].Height = BlockSize;
                    colors[r, c].Width = BlockSize;

                    SetColor(colors[r, c]);
                    //colors[r, c].BackColor = Color.Yellow;

                    this.Controls.Add(colors[r, c]);
                }
            }


        }

        private void SetColor(Label l)
        {
            int red, green, blue, avg;
            red = GenerateRandRange(0, 255);
            green = GenerateRandRange(0, 255);
            blue = GenerateRandRange(0, 255);
            avg = (red + green + blue) / 3;
            
            l.BackColor = Color.FromArgb(red, green, blue);
            l.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
            if (avg < 127)
                l.ForeColor = Color.White;
            else
                l.ForeColor = Color.Black;

            l.Text = "#" + red.ToString("X") + green.ToString("X") + blue.ToString("X");

        }

        private void ClearLabels()
        {
            for (int r = 0; r < MaxDimSize; r++)
            {
                for (int c = 0; c < MaxDimSize; c++)
                {
                    this.Controls.Remove(colors[r, c]);
                }
            }
            //colors = new Label[MaxDimSize, MaxDimSize];

        }

        private int GenerateRandRange(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }


        #endregion

    }
}
