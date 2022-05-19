
namespace _02Week03Demob_TempConverter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInputTemp = new System.Windows.Forms.TextBox();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radF = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblSym = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttpMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Temperature Converter";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 49);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(131, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "&Input Temperature";
            // 
            // txtInputTemp
            // 
            this.txtInputTemp.Location = new System.Drawing.Point(13, 73);
            this.txtInputTemp.Name = "txtInputTemp";
            this.txtInputTemp.Size = new System.Drawing.Size(125, 27);
            this.txtInputTemp.TabIndex = 2;
            this.ttpMainForm.SetToolTip(this.txtInputTemp, "Input your starting temperature as a decimal");
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(144, 76);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(39, 24);
            this.radC.TabIndex = 3;
            this.radC.TabStop = true;
            this.radC.Text = "&C";
            this.ttpMainForm.SetToolTip(this.radC, "Choose Celcius as your starting unit");
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(190, 76);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(37, 24);
            this.radF.TabIndex = 4;
            this.radF.TabStop = true;
            this.radF.Text = "&F";
            this.ttpMainForm.SetToolTip(this.radF, "Choose Fahrenheit as your starting unit");
            this.radF.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(233, 76);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Con&vert";
            this.ttpMainForm.SetToolTip(this.btnConvert, "Convert button to perform the actual calculation");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(343, 79);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(62, 25);
            this.lblAnswer.TabIndex = 6;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(411, 81);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(0, 20);
            this.lblSymbol.TabIndex = 7;
            // 
            // lblSym
            // 
            this.lblSym.AutoSize = true;
            this.lblSym.Location = new System.Drawing.Point(418, 78);
            this.lblSym.Name = "lblSym";
            this.lblSym.Size = new System.Drawing.Size(15, 20);
            this.lblSym.TabIndex = 8;
            this.lblSym.Text = "°";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(430, 79);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(15, 20);
            this.lblUnits.TabIndex = 9;
            this.lblUnits.Text = "-";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Re&set";
            this.ttpMainForm.SetToolTip(this.btnReset, "Reset all form values to their initial default state");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(356, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.ttpMainForm.SetToolTip(this.btnExit, "Exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(472, 192);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblSym);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radF);
            this.Controls.Add(this.radC);
            this.Controls.Add(this.txtInputTemp);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 03 Demo B Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInputTemp;
        private System.Windows.Forms.ToolTip ttpMainForm;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblSym;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

