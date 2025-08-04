namespace Calculator
{
    public partial class Calculator : Form
    {
        private string currentInput = "";
        private string storedValue = "";
        private string currentOperator = "";
        private double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        // Bot�es num�ricos (0-9)   
        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentInput += button.Text;
            UpdateScreen();
        }

        // Bot�es de operadores (+, -, *, /, x^y)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentOperator = ((Button)sender).Text;
                storedValue = currentInput;
                currentInput = "";
            }
        }

        // Resultado da opera��o
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(storedValue) || string.IsNullOrEmpty(currentInput))
                return;

            double num1 = Convert.ToDouble(storedValue);
            double num2 = Convert.ToDouble(currentInput);

            result = currentOperator switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                "x^y" => Math.Pow(num1, num2),
                _ => result
            };

            if (currentOperator == "/" && num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return;
            }

            currentInput = result.ToString();
            UpdateScreen();
            currentOperator = "";
        }

        // Limpar a tela e resetar os valores
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            storedValue = "";
            currentOperator = "";
            Screen.Text = "0";
        }

        // Divis�o de 1 por X
        private void btnOneByX_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = (1.0 / Convert.ToDouble(currentInput)).ToString();
                UpdateScreen();
            }
        }

        // Calcular a ra�z do valor
        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = Math.Sqrt(Convert.ToDouble(currentInput)).ToString();
                UpdateScreen();
            }
        }

        // Colocar um ponto decimal
        private void numDot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                UpdateScreen();
            }
        }

        // Inverter o sinal do n�mero (positivo/negativo)
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = currentInput.StartsWith("-") ?
                    currentInput.Substring(1) :
                    "-" + currentInput;
                UpdateScreen();
            }
        }

        // Calcular o seno do valor
        private void btnSen_Click(object sender, EventArgs e)
        {
            result = Math.Sin(Convert.ToDouble(currentInput));
            Screen.Text = result.ToString();
        }

        // Calcular o cosseno do valor
        private void btnCos_Click(object sender, EventArgs e)
        {
            result = Math.Cos(Convert.ToDouble(currentInput));
            Screen.Text = result.ToString();
        }

        // Colocar o valor de PI no display
        private void btnPi_Click(object sender, EventArgs e)
        {
            currentInput += Math.PI.ToString();
            UpdateScreen();
        }

        // Fun��o para atualizar o display da calculadora
        private void UpdateScreen()
        {
            Screen.Text = string.IsNullOrEmpty(currentInput) ? "0" : currentInput;
        }

        // Check para ativar / desativar o modo escuro
        private void checkDM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDM.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        // Check para ativar / desativar o modo cient�fico
        private void radioStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStandard.Checked)
            {
                resizeNumberButtons(new Size(70, 70));
                repositionStandardMode();
                btnSen.Visible = false;
                btnCos.Visible = false;
                btnXpowerY.Visible = false;
                btnCalcX.Visible = false;
                btnPi.Visible = false;  

                btnDot.Location = new Point(89, 347);
                btnPlusMinus.Location = new Point(165, 347);
            }
        }

        private void radioScientific_CheckedChanged(object sender, EventArgs e)
        {
            if (radioScientific.Checked)
            {
                resizeNumberButtons(new Size(50, 50));
                repositionScientificMode();
                btnSen.Visible = true;
                btnCos.Visible = true;
                btnXpowerY.Visible = true;
                btnCalcX.Visible = true;
                btnPi.Visible = true;

                btnDot.Location = new Point(num0.Right + 6, num2.Bottom + 6);
                btnPlusMinus.Location = new Point(btnDot.Right + 6, num3.Bottom + 6);
            }
        }

        // M�todo para mudar o tamanho dos bot�es de acordo com o modo (Padr�o ou Cientifico)
        private void resizeNumberButtons(Size newSize)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (Controls.Find($"num{i}", true).FirstOrDefault() is Button numButton)
                {
                    numButton.Size = newSize;
                }
            }
            btnDot.Size = newSize;
            btnPlusMinus.Size = newSize;
        }

        // Fun��o para reposicionar os bot�es no modo padr�o
        private void repositionStandardMode()
        {
            int startX = 13;
            int startY = 119;
            int buttonSpacing = 6;

            for (int i = 1; i <= 9; i++)
            {
                if (Controls.Find($"num{i}", true).FirstOrDefault() is Button numButton)
                {
                    int row = (9 - i) / 3; // Linhas v�o de baixo pra cima (7,8,9 -> 4,5,6 -> 1,2,3)
                    int col = (i - 1) % 3; // Colunas 0,1,2
                    numButton.Location = new Point(
                        startX + col * (numButton.Width + buttonSpacing),
                        startY + row * (numButton.Height + buttonSpacing)
                    );
                }
            }

            // Posi��o do bot�o 0 abaixo do bot�o 1 (centralizado)
            if (Controls.Find("num0", true).FirstOrDefault() is Button zeroButton)
            {
                // Achar o bot�o 0 abaixo do bot�o 1
                if (Controls.Find("num1", true).FirstOrDefault() is Button oneButton)
                {
                    zeroButton.Location = new Point(
                        oneButton.Left,
                        oneButton.Bottom + buttonSpacing
                    );
                }
                else  // Voltar se o bot�o 1 n�o for encontrado
                {
                    zeroButton.Location = new Point(
                        startX + (zeroButton.Width + buttonSpacing),  // Centralizar posi��o
                        startY + 3 * (zeroButton.Height + buttonSpacing)  // Abaixo da 3� linha
                    );
                }
            }
        }

        // Fun��o para reposicionar os bot�es no modo cient�fico
        private void repositionScientificMode()
        {
            int startX = 13;
            int startY = 119;
            int buttonSpacing = 6;

            for (int i = 1; i <= 9; i++)
            {
                if (Controls.Find($"num{i}", true).FirstOrDefault() is Button numButton)
                {
                    int row = (9 - i) / 3; // Linhas v�o de baixo pra cima (7,8,9 -> 4,5,6 -> 1,2,3)
                    int col = (i - 1) % 3; // Colunas 0,1,2
                    numButton.Location = new Point(
                        startX + col * (numButton.Width + buttonSpacing),
                        startY + row * (numButton.Height + buttonSpacing)
                    );
                }
            }

            // Posi��o do bot�o 0 abaixo do bot�o 1 (centralizado)
            if (Controls.Find("num0", true).FirstOrDefault() is Button zeroButton)
            {
                // Achar o bot�o 0 abaixo do bot�o 1
                if (Controls.Find("num1", true).FirstOrDefault() is Button oneButton)
                {
                    zeroButton.Location = new Point(
                        oneButton.Left,
                        oneButton.Bottom + buttonSpacing
                    );
                }
                else  // Voltar se o bot�o 1 n�o for encontrado
                {
                    zeroButton.Location = new Point(
                        startX + (zeroButton.Width + buttonSpacing),  // Centralizar posi��o
                        startY + 3 * (zeroButton.Height + buttonSpacing)  // Abaixo da 3� linha
                    );
                }
            }
        }
    }
}