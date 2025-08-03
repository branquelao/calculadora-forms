namespace Calculator
{
    partial class Form1
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
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            Screen = new TextBox();
            num0 = new Button();
            numDot = new Button();
            btnPlusMinus = new Button();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            btnClear = new Button();
            btnMult = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnDiv = new Button();
            btnOneByX = new Button();
            btnRoot = new Button();
            btnEquals = new Button();
            radioStandard = new RadioButton();
            radioScientific = new RadioButton();
            checkDM = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(525, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Options";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkDM);
            tabPage1.Controls.Add(radioScientific);
            tabPage1.Controls.Add(radioStandard);
            tabPage1.Controls.Add(btnEquals);
            tabPage1.Controls.Add(btnRoot);
            tabPage1.Controls.Add(btnOneByX);
            tabPage1.Controls.Add(btnDiv);
            tabPage1.Controls.Add(btnMinus);
            tabPage1.Controls.Add(btnPlus);
            tabPage1.Controls.Add(btnMult);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(num9);
            tabPage1.Controls.Add(num8);
            tabPage1.Controls.Add(num7);
            tabPage1.Controls.Add(num6);
            tabPage1.Controls.Add(num5);
            tabPage1.Controls.Add(num4);
            tabPage1.Controls.Add(num3);
            tabPage1.Controls.Add(num2);
            tabPage1.Controls.Add(num1);
            tabPage1.Controls.Add(btnPlusMinus);
            tabPage1.Controls.Add(numDot);
            tabPage1.Controls.Add(num0);
            tabPage1.Controls.Add(Screen);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(525, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Screen
            // 
            Screen.Font = new Font("Segoe UI", 40F);
            Screen.Location = new Point(16, 19);
            Screen.Multiline = true;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.Size = new Size(492, 74);
            Screen.TabIndex = 24;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            // 
            // num0
            // 
            num0.BackColor = Color.Black;
            num0.ForeColor = Color.White;
            num0.Location = new Point(17, 354);
            num0.Name = "num0";
            num0.Size = new Size(70, 70);
            num0.TabIndex = 25;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = false;
            num0.Click += NumberButton_Click;
            // 
            // numDot
            // 
            numDot.BackColor = Color.Black;
            numDot.ForeColor = Color.White;
            numDot.Location = new Point(93, 354);
            numDot.Name = "numDot";
            numDot.Size = new Size(70, 70);
            numDot.TabIndex = 26;
            numDot.Text = ".";
            numDot.UseVisualStyleBackColor = false;
            numDot.Click += numDot_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.Black;
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Location = new Point(169, 354);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(70, 70);
            btnPlusMinus.TabIndex = 27;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // num1
            // 
            num1.BackColor = Color.Black;
            num1.ForeColor = Color.White;
            num1.Location = new Point(17, 278);
            num1.Name = "num1";
            num1.Size = new Size(70, 70);
            num1.TabIndex = 28;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.Click += NumberButton_Click;
            // 
            // num2
            // 
            num2.BackColor = Color.Black;
            num2.ForeColor = Color.White;
            num2.Location = new Point(93, 278);
            num2.Name = "num2";
            num2.Size = new Size(70, 70);
            num2.TabIndex = 29;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += NumberButton_Click;
            // 
            // num3
            // 
            num3.BackColor = Color.Black;
            num3.ForeColor = Color.White;
            num3.Location = new Point(169, 278);
            num3.Name = "num3";
            num3.Size = new Size(70, 70);
            num3.TabIndex = 30;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += NumberButton_Click;
            // 
            // num4
            // 
            num4.BackColor = Color.Black;
            num4.ForeColor = Color.White;
            num4.Location = new Point(17, 202);
            num4.Name = "num4";
            num4.Size = new Size(70, 70);
            num4.TabIndex = 31;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += NumberButton_Click;
            // 
            // num5
            // 
            num5.BackColor = Color.Black;
            num5.ForeColor = Color.White;
            num5.Location = new Point(93, 202);
            num5.Name = "num5";
            num5.Size = new Size(70, 70);
            num5.TabIndex = 32;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += NumberButton_Click;
            // 
            // num6
            // 
            num6.BackColor = Color.Black;
            num6.ForeColor = Color.White;
            num6.Location = new Point(169, 202);
            num6.Name = "num6";
            num6.Size = new Size(70, 70);
            num6.TabIndex = 33;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += NumberButton_Click;
            // 
            // num7
            // 
            num7.BackColor = Color.Black;
            num7.ForeColor = Color.White;
            num7.Location = new Point(17, 126);
            num7.Name = "num7";
            num7.Size = new Size(70, 70);
            num7.TabIndex = 34;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += NumberButton_Click;
            // 
            // num8
            // 
            num8.BackColor = Color.Black;
            num8.ForeColor = Color.White;
            num8.Location = new Point(93, 126);
            num8.Name = "num8";
            num8.Size = new Size(70, 70);
            num8.TabIndex = 35;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += NumberButton_Click;
            // 
            // num9
            // 
            num9.BackColor = Color.Black;
            num9.ForeColor = Color.White;
            num9.Location = new Point(169, 126);
            num9.Name = "num9";
            num9.Size = new Size(70, 70);
            num9.TabIndex = 36;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += NumberButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.Location = new Point(286, 126);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(222, 70);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(255, 128, 0);
            btnMult.ForeColor = Color.White;
            btnMult.Location = new Point(286, 278);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(70, 70);
            btnMult.TabIndex = 38;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += OperatorButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(286, 202);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(70, 70);
            btnPlus.TabIndex = 39;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(362, 202);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(70, 70);
            btnMinus.TabIndex = 40;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OperatorButton_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 128, 0);
            btnDiv.ForeColor = Color.White;
            btnDiv.Location = new Point(362, 278);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 70);
            btnDiv.TabIndex = 41;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += OperatorButton_Click;
            // 
            // btnOneByX
            // 
            btnOneByX.BackColor = Color.CornflowerBlue;
            btnOneByX.ForeColor = Color.White;
            btnOneByX.Location = new Point(286, 354);
            btnOneByX.Name = "btnOneByX";
            btnOneByX.Size = new Size(70, 70);
            btnOneByX.TabIndex = 42;
            btnOneByX.Text = "1/X";
            btnOneByX.UseVisualStyleBackColor = false;
            btnOneByX.Click += btnOneByX_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.CornflowerBlue;
            btnRoot.ForeColor = Color.White;
            btnRoot.Location = new Point(362, 354);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(70, 70);
            btnRoot.TabIndex = 43;
            btnRoot.Text = "✓";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.CornflowerBlue;
            btnEquals.ForeColor = Color.White;
            btnEquals.Location = new Point(438, 202);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 222);
            btnEquals.TabIndex = 44;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // radioStandard
            // 
            radioStandard.AutoSize = true;
            radioStandard.Checked = true;
            radioStandard.Location = new Point(17, 101);
            radioStandard.Name = "radioStandard";
            radioStandard.Size = new Size(72, 19);
            radioStandard.TabIndex = 45;
            radioStandard.TabStop = true;
            radioStandard.Text = "Standard";
            radioStandard.UseVisualStyleBackColor = true;
            // 
            // radioScientific
            // 
            radioScientific.AutoSize = true;
            radioScientific.Location = new Point(117, 101);
            radioScientific.Name = "radioScientific";
            radioScientific.Size = new Size(73, 19);
            radioScientific.TabIndex = 46;
            radioScientific.Text = "Scientific";
            radioScientific.UseVisualStyleBackColor = true;
            // 
            // checkDM
            // 
            checkDM.AutoSize = true;
            checkDM.Location = new Point(286, 102);
            checkDM.Name = "checkDM";
            checkDM.Size = new Size(81, 19);
            checkDM.TabIndex = 47;
            checkDM.Text = "Darkmode";
            checkDM.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(533, 470);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 468);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Calculator";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private CheckBox checkDM;
        private RadioButton radioScientific;
        private RadioButton radioStandard;
        private Button btnEquals;
        private Button btnRoot;
        private Button btnOneByX;
        private Button btnDiv;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnMult;
        private Button btnClear;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button btnPlusMinus;
        private Button numDot;
        private Button num0;
        private TextBox Screen;
        private TabControl tabControl1;
    }
}
