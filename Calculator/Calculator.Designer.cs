namespace Calculator
{
    partial class Calculator
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
            checkDM = new CheckBox();
            radioScientific = new RadioButton();
            radioStandard = new RadioButton();
            btnEquals = new Button();
            btnRoot = new Button();
            btnOneByX = new Button();
            btnDiv = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnMult = new Button();
            btnClear = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            btnPlusMinus = new Button();
            btnDot = new Button();
            num0 = new Button();
            Screen = new TextBox();
            btnSen = new Button();
            btnCos = new Button();
            btnXpowerY = new Button();
            btnCalcX = new Button();
            btnPi = new Button();
            SuspendLayout();
            // 
            // checkDM
            // 
            checkDM.AutoSize = true;
            checkDM.Location = new Point(272, 95);
            checkDM.Name = "checkDM";
            checkDM.Size = new Size(81, 19);
            checkDM.TabIndex = 71;
            checkDM.Text = "Darkmode";
            checkDM.UseVisualStyleBackColor = true;
            checkDM.Click += checkDM_CheckedChanged;
            // 
            // radioScientific
            // 
            radioScientific.AutoSize = true;
            radioScientific.Location = new Point(122, 94);
            radioScientific.Name = "radioScientific";
            radioScientific.Size = new Size(73, 19);
            radioScientific.TabIndex = 70;
            radioScientific.Text = "Scientific";
            radioScientific.UseVisualStyleBackColor = true;
            radioScientific.CheckedChanged += radioScientific_CheckedChanged;
            // 
            // radioStandard
            // 
            radioStandard.AutoSize = true;
            radioStandard.Checked = true;
            radioStandard.Location = new Point(22, 94);
            radioStandard.Name = "radioStandard";
            radioStandard.Size = new Size(72, 19);
            radioStandard.TabIndex = 69;
            radioStandard.TabStop = true;
            radioStandard.Text = "Standard";
            radioStandard.UseVisualStyleBackColor = true;
            radioStandard.CheckedChanged += radioStandard_CheckedChanged;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Black;
            btnEquals.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnEquals.ForeColor = Color.White;
            btnEquals.Location = new Point(415, 195);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 222);
            btnEquals.TabIndex = 68;
            btnEquals.TabStop = false;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.Black;
            btnRoot.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnRoot.ForeColor = Color.White;
            btnRoot.Location = new Point(339, 347);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(70, 70);
            btnRoot.TabIndex = 67;
            btnRoot.TabStop = false;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnOneByX
            // 
            btnOneByX.BackColor = Color.Black;
            btnOneByX.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnOneByX.ForeColor = Color.White;
            btnOneByX.Location = new Point(263, 347);
            btnOneByX.Name = "btnOneByX";
            btnOneByX.Size = new Size(70, 70);
            btnOneByX.TabIndex = 66;
            btnOneByX.TabStop = false;
            btnOneByX.Text = "1/X";
            btnOneByX.UseVisualStyleBackColor = false;
            btnOneByX.Click += btnOneByX_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Black;
            btnDiv.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnDiv.ForeColor = Color.White;
            btnDiv.Location = new Point(339, 271);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 70);
            btnDiv.TabIndex = 65;
            btnDiv.TabStop = false;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Black;
            btnMinus.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(339, 195);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(70, 70);
            btnMinus.TabIndex = 64;
            btnMinus.TabStop = false;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OperatorButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Black;
            btnPlus.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(263, 195);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(70, 70);
            btnPlus.TabIndex = 63;
            btnPlus.TabStop = false;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Black;
            btnMult.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnMult.ForeColor = Color.White;
            btnMult.Location = new Point(263, 271);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(70, 70);
            btnMult.TabIndex = 62;
            btnMult.TabStop = false;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += OperatorButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(263, 119);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(222, 70);
            btnClear.TabIndex = 61;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // num9
            // 
            num9.BackColor = Color.Gray;
            num9.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num9.ForeColor = Color.White;
            num9.Location = new Point(165, 119);
            num9.Name = "num9";
            num9.Size = new Size(70, 70);
            num9.TabIndex = 60;
            num9.TabStop = false;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += NumberButton_Click;
            // 
            // num8
            // 
            num8.BackColor = Color.Gray;
            num8.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num8.ForeColor = Color.White;
            num8.Location = new Point(89, 119);
            num8.Name = "num8";
            num8.Size = new Size(70, 70);
            num8.TabIndex = 59;
            num8.TabStop = false;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += NumberButton_Click;
            // 
            // num7
            // 
            num7.BackColor = Color.Gray;
            num7.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num7.ForeColor = Color.White;
            num7.Location = new Point(13, 119);
            num7.Name = "num7";
            num7.Size = new Size(70, 70);
            num7.TabIndex = 58;
            num7.TabStop = false;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += NumberButton_Click;
            // 
            // num6
            // 
            num6.BackColor = Color.Gray;
            num6.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num6.ForeColor = Color.White;
            num6.Location = new Point(165, 195);
            num6.Name = "num6";
            num6.Size = new Size(70, 70);
            num6.TabIndex = 57;
            num6.TabStop = false;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += NumberButton_Click;
            // 
            // num5
            // 
            num5.BackColor = Color.Gray;
            num5.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num5.ForeColor = Color.White;
            num5.Location = new Point(89, 195);
            num5.Name = "num5";
            num5.Size = new Size(70, 70);
            num5.TabIndex = 56;
            num5.TabStop = false;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += NumberButton_Click;
            // 
            // num4
            // 
            num4.BackColor = Color.Gray;
            num4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num4.ForeColor = Color.White;
            num4.Location = new Point(13, 195);
            num4.Name = "num4";
            num4.Size = new Size(70, 70);
            num4.TabIndex = 55;
            num4.TabStop = false;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += NumberButton_Click;
            // 
            // num3
            // 
            num3.BackColor = Color.Gray;
            num3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num3.ForeColor = Color.White;
            num3.Location = new Point(165, 271);
            num3.Name = "num3";
            num3.Size = new Size(70, 70);
            num3.TabIndex = 54;
            num3.TabStop = false;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += NumberButton_Click;
            // 
            // num2
            // 
            num2.BackColor = Color.Gray;
            num2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num2.ForeColor = Color.White;
            num2.Location = new Point(89, 271);
            num2.Name = "num2";
            num2.Size = new Size(70, 70);
            num2.TabIndex = 53;
            num2.TabStop = false;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += NumberButton_Click;
            // 
            // num1
            // 
            num1.BackColor = Color.Gray;
            num1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num1.ForeColor = Color.White;
            num1.Location = new Point(13, 271);
            num1.Name = "num1";
            num1.Size = new Size(70, 70);
            num1.TabIndex = 52;
            num1.TabStop = false;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.Click += NumberButton_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.Gray;
            btnPlusMinus.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Location = new Point(165, 347);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(70, 70);
            btnPlusMinus.TabIndex = 51;
            btnPlusMinus.TabStop = false;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Gray;
            btnDot.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnDot.ForeColor = Color.White;
            btnDot.Location = new Point(89, 347);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(70, 70);
            btnDot.TabIndex = 50;
            btnDot.TabStop = false;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += numDot_Click;
            // 
            // num0
            // 
            num0.BackColor = Color.Gray;
            num0.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            num0.ForeColor = Color.White;
            num0.Location = new Point(13, 347);
            num0.Name = "num0";
            num0.Size = new Size(70, 70);
            num0.TabIndex = 49;
            num0.TabStop = false;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = false;
            num0.Click += NumberButton_Click;
            // 
            // Screen
            // 
            Screen.BackColor = Color.DarkSeaGreen;
            Screen.Font = new Font("Trebuchet MS", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Screen.ForeColor = Color.FromArgb(64, 64, 64);
            Screen.Location = new Point(13, 12);
            Screen.Multiline = true;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.Size = new Size(472, 74);
            Screen.TabIndex = 48;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSen
            // 
            btnSen.BackColor = Color.Gray;
            btnSen.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSen.ForeColor = Color.White;
            btnSen.Location = new Point(185, 119);
            btnSen.Name = "btnSen";
            btnSen.Size = new Size(50, 50);
            btnSen.TabIndex = 72;
            btnSen.TabStop = false;
            btnSen.Text = "sen";
            btnSen.UseVisualStyleBackColor = false;
            btnSen.Visible = false;
            btnSen.Click += btnSen_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.Gray;
            btnCos.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCos.ForeColor = Color.White;
            btnCos.Location = new Point(185, 175);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(50, 50);
            btnCos.TabIndex = 73;
            btnCos.TabStop = false;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Visible = false;
            btnCos.Click += btnCos_Click;
            // 
            // btnXpowerY
            // 
            btnXpowerY.BackColor = Color.Gray;
            btnXpowerY.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnXpowerY.ForeColor = Color.White;
            btnXpowerY.Location = new Point(185, 231);
            btnXpowerY.Name = "btnXpowerY";
            btnXpowerY.Size = new Size(50, 50);
            btnXpowerY.TabIndex = 74;
            btnXpowerY.TabStop = false;
            btnXpowerY.Text = "x^y";
            btnXpowerY.UseVisualStyleBackColor = false;
            btnXpowerY.Visible = false;
            btnXpowerY.Click += OperatorButton_Click;
            // 
            // btnCalcX
            // 
            btnCalcX.BackColor = Color.Gray;
            btnCalcX.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold);
            btnCalcX.ForeColor = Color.White;
            btnCalcX.Location = new Point(13, 347);
            btnCalcX.Name = "btnCalcX";
            btnCalcX.Size = new Size(222, 70);
            btnCalcX.TabIndex = 75;
            btnCalcX.TabStop = false;
            btnCalcX.Text = "Calculate X";
            btnCalcX.UseVisualStyleBackColor = false;
            btnCalcX.Visible = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.Gray;
            btnPi.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPi.ForeColor = Color.White;
            btnPi.Location = new Point(185, 287);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(50, 50);
            btnPi.TabIndex = 76;
            btnPi.TabStop = false;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Visible = false;
            btnPi.Click += btnPi_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 431);
            Controls.Add(btnPi);
            Controls.Add(btnCalcX);
            Controls.Add(btnXpowerY);
            Controls.Add(btnCos);
            Controls.Add(btnSen);
            Controls.Add(checkDM);
            Controls.Add(radioScientific);
            Controls.Add(radioStandard);
            Controls.Add(btnEquals);
            Controls.Add(btnRoot);
            Controls.Add(btnOneByX);
            Controls.Add(btnDiv);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnMult);
            Controls.Add(btnClear);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDot);
            Controls.Add(num0);
            Controls.Add(Screen);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkDM;
        private RadioButton radioScientific;
        private RadioButton radioStandard;
        private TextBox Screen;
        internal Button btnEquals;
        internal Button btnRoot;
        internal Button btnOneByX;
        internal Button btnDiv;
        internal Button btnMinus;
        internal Button btnPlus;
        internal Button btnMult;
        internal Button btnClear;
        internal Button num9;
        internal Button num8;
        internal Button num7;
        internal Button num6;
        internal Button num5;
        internal Button num4;
        internal Button num3;
        internal Button num2;
        internal Button num1;
        internal Button btnPlusMinus;
        internal Button btnDot;
        internal Button num0;
        internal Button btnSen;
        internal Button btnCos;
        internal Button btnXpowerY;
        internal Button btnCalcX;
        internal Button btnPi;
    }
}
