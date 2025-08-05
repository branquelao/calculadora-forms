namespace Calculator
{
    public partial class Calculator : Form
    {
        private string currentInput = "";
        private string storedValue = "";
        private string currentOperator = "";
        private double result = 0.0;
        private readonly ButtonLayoutManager _buttonLayoutManager;

        public Calculator()
        {
            InitializeComponent();
            _buttonLayoutManager = new ButtonLayoutManager(this);
        }

        // Botões numéricos (0-9)   
        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentInput += button.Text;
            UpdateScreen();
        }

        // Botões de operadores (+, -, *, /, x^y)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentOperator = ((Button)sender).Text;
                storedValue = currentInput;
                currentInput = "";
            }
        }

        // Resultado da operação
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

        // Divisão de 1 por X
        private void btnOneByX_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = (1.0 / Convert.ToDouble(currentInput)).ToString();
                UpdateScreen();
            }
        }

        // Calcular a raíz do valor
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

        // Inverter o sinal do número (positivo/negativo)
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
            currentInput = Math.PI.ToString();
            UpdateScreen();
        }

        // Função para atualizar o display da calculadora
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

        // Check para ativar / desativar o modo científico
        private void radioStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStandard.Checked)
            {
                _buttonLayoutManager.ResizeNumberButtons(_buttonLayoutManager.StandardButtonSize);
                _buttonLayoutManager.RepositionStandardMode();

                btnSen.Visible = false;
                btnCos.Visible = false;
                btnXpowerY.Visible = false;
                btnCalcX.Visible = false;
                btnPi.Visible = false;

                var btnDot = Controls.Find("btnDot", true).FirstOrDefault() as Button;
                var btnPlusMinus = Controls.Find("btnPlusMinus", true).FirstOrDefault() as Button;

                if (btnDot != null) btnDot.Location = new Point(89, 347);
                if (btnPlusMinus != null) btnPlusMinus.Location = new Point(165, 347);
            }
        }

        private void radioScientific_CheckedChanged(object sender, EventArgs e)
        {
            if (radioScientific.Checked)
            {
                _buttonLayoutManager.ResizeNumberButtons(_buttonLayoutManager.ScientificButtonSize);
                _buttonLayoutManager.RepositionScientificMode();

                btnSen.Visible = true;
                btnCos.Visible = true;
                btnXpowerY.Visible = true;
                btnCalcX.Visible = true;
                btnPi.Visible = true;
            }
        }
    }
}