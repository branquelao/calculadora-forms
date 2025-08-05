using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ButtonLayoutManager
    {
        private readonly Form _form;
        private readonly Size _standardSize = new Size(70, 70);
        private readonly Size _scientificSize = new Size(50, 50);
        private readonly int _buttonSpacing = 6;

        public ButtonLayoutManager(Form form)
        {
            _form = form;
        }

        // Método para mudar o tamanho dos botões de acordo com o modo (Padrão ou Cientifico)
        public void ResizeNumberButtons(Size newSize)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (_form.Controls.Find($"num{i}", true).FirstOrDefault() is Button numButton)
                {
                    numButton.Size = newSize;
                }
            }

            var btnDot = _form.Controls.Find("btnDot", true).FirstOrDefault() as Button;
            var btnPlusMinus = _form.Controls.Find("btnPlusMinus", true).FirstOrDefault() as Button;

            if (btnDot != null) btnDot.Size = newSize;
            if (btnPlusMinus != null) btnPlusMinus.Size = newSize;
        }

        // Função para reposicionar os botões no modo padrão
        public void RepositionStandardMode()
        {
            int startX = 13;
            int startY = 119;

            for (int i = 1; i <= 9; i++)
            {
                if (_form.Controls.Find($"num{i}", true).FirstOrDefault() is Button numButton)
                {
                    int row = (9 - i) / 3; // Linhas vão de baixo pra cima (7,8,9 -> 4,5,6 -> 1,2,3)
                    int col = (i - 1) % 3; // Colunas 0,1,2
                    numButton.Location = new Point(
                        startX + col * (numButton.Width + _buttonSpacing),
                        startY + row * (numButton.Height + _buttonSpacing)
                    );
                }
            }

            // Posição do botão 0 abaixo do botão 1 (centralizado)
            if (_form.Controls.Find("num0", true).FirstOrDefault() is Button zeroButton)
            {
                // Achar o botão 0 abaixo do botão 1
                if (_form.Controls.Find("num1", true).FirstOrDefault() is Button oneButton)
                {
                    zeroButton.Location = new Point(
                        oneButton.Left,
                        oneButton.Bottom + _buttonSpacing
                    );
                }
                else // Voltar se o botão 1 não for encontrado
                {
                    zeroButton.Location = new Point(
                        startX + (zeroButton.Width + _buttonSpacing), // Centralizar posição
                        startY + 3 * (zeroButton.Height + _buttonSpacing) // Abaixo da 3ª linha
                    );
                }
            }
        }

        // Função para reposicionar os botões no modo científico
        public void RepositionScientificMode()
        {
            RepositionStandardMode();

            var btnDot = _form.Controls.Find("btnDot", true).FirstOrDefault() as Button;
            var btnPlusMinus = _form.Controls.Find("btnPlusMinus", true).FirstOrDefault() as Button;
            var num0 = _form.Controls.Find("num0", true).FirstOrDefault() as Button;
            var num2 = _form.Controls.Find("num2", true).FirstOrDefault() as Button;
            var num3 = _form.Controls.Find("num3", true).FirstOrDefault() as Button;

            if (btnDot != null && num0 != null && num2 != null)
            {
                btnDot.Location = new Point(num0.Right + _buttonSpacing, num2.Bottom + _buttonSpacing);
            }

            if (btnPlusMinus != null && num3 != null && btnDot != null)
            {
                btnPlusMinus.Location = new Point(btnDot.Right + _buttonSpacing, num3.Bottom + _buttonSpacing);
            }
        }

        public Size StandardButtonSize => _standardSize;
        public Size ScientificButtonSize => _scientificSize;
    }
}
