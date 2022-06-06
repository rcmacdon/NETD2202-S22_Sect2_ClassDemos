using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Week06Demo1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Global Variables
        const int NumLabels = 10;
        List<Label> TheLabels;
        //Queue<Label> name1;
        //Stack<Label> name 2;

        // Lists, Queues, and Stacks are generic collections
        // List is a object thrown in a box in random order
        // Queue is FIFO lineup (like a line at a bar)
        // Stack is LIFO pile (like a stack of books)

        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateHeader("Week 6 - Demo 1");
            TheLabels = new List<Label>();
        }

        private void CreateHeader(String headerText)
        {
            Label header = new Label();
            header.Name = "lblHeader";
            header.Text = headerText;

            // position 
            header.AutoSize = false;
            header.Top = 0;
            header.Left = 0;
            header.Height = 40;
            header.Width = this.Width;
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Colours and fonts
            header.BackColor = Color.Black;
            header.ForeColor = Color.White;
            header.TextAlign = ContentAlignment.MiddleCenter;
            header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.Controls.Add(header);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl;

            // Create the labels
            for (int i = 0; i < NumLabels; i++)
            {
                lbl = new Label();
                lbl.Name = "lblTemp" + i.ToString();
                lbl.Text = "Clint's Label " + i.ToString();
                TheLabels.Add(lbl);
            }

            // Display on the form
            int numLabels = TheLabels.Count;
            int left = 10;
            int top = button1.Top + button1.Height + 10;

            foreach(Label myLbl in TheLabels)
            {
                myLbl.Left = left;
                myLbl.Top = top;
                this.Controls.Add(myLbl);

                top += myLbl.Height + 5;
            }
            

        }
    }
}
