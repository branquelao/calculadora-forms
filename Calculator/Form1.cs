namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private string storedValue = "";
        private string currentOperator = "";
        private double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        // Handles all number button clicks (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentInput += button.Text;
            UpdateScreen();
        }

        // Handles all operator button clicks (+, -, *, /)
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentOperator = ((Button)sender).Text;
                storedValue = currentInput;
                currentInput = "";
            }
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            storedValue = "";
            currentOperator = "";
            Screen.Text = "0";
        }

        private void btnOneByX_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = (1.0 / Convert.ToDouble(currentInput)).ToString();
                UpdateScreen();
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentInput = Math.Sqrt(Convert.ToDouble(currentInput)).ToString();
                UpdateScreen();
            }
        }

        private void numDot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                UpdateScreen();
            }
        }

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

        private void UpdateScreen()
        {
            Screen.Text = string.IsNullOrEmpty(currentInput) ? "0" : currentInput;
        }
    }
}