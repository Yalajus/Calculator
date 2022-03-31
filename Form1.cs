using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool hasEqualed = false;
        
        public Calculator()
        {
            InitializeComponent();
            buttonEqual.Select();

        }

        public void buttonClick(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed) || (hasEqualed))
                textBoxResult.Text = "";
            isOperationPerformed = false;
            hasEqualed = false;
            Button button = (Button) sender;

            
            textBoxResult.Text = textBoxResult.Text + button.Text;
            if (textBoxResult.Text.EndsWith("."))
                buttonPeriod.Enabled = false;
            buttonEqual.Select();

        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            isOperationPerformed = true;
            resultValue = Convert.ToDouble(textBoxResult.Text);

            label1.Text = textBoxResult.Text + " " + operationPerformed;
            buttonPeriod.Enabled = true;
            buttonEqual.Select();
        }

        private void buttonEquals(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    resultValue = resultValue + Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    hasEqualed = true;
                    break;
                case "-":
                    resultValue = resultValue - Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    hasEqualed = true;
                    break;
                case "*":
                    resultValue = resultValue * Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    hasEqualed = true;
                    break;
                case "/":
                    resultValue = resultValue / Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    hasEqualed = true;
                    break;
                default:
                    break;
            }
        }

        private void clearEntryButton(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void clearButton(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
            label1.Text = "";
            buttonEqual.Select();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((char)e.KeyChar)
            {
                case '0':
                    textBoxResult.Text = textBoxResult.Text + "0";
                    break;
                case '1':
                    buttonClick(buttonOne, e);
                    break;
                case '2':
                    buttonClick(buttonTwo, e);
                    break;
                case '3':
                    buttonClick(buttonThree, e);
                    break;
                case '4':
                    buttonClick(buttonFour, e);
                    break;
                case '5':
                    buttonClick(buttonFive, e);
                    break;
                case '6':
                    buttonClick(buttonSix, e);
                    break;
                case '7':
                    buttonClick(buttonSeven, e);
                    break;
                case '8':
                    buttonClick(buttonEight, e);
                    break;
                case '9':
                    buttonClick(buttonNine, e);
                    break;
                case '+':
                    operatorClick(buttonPlus, e);
                    break;
                case '/':
                    operatorClick(buttonDivide, e);
                    break;
                case '*':
                    operatorClick(buttonTimes, e);
                    break;
                case '-':
                    operatorClick(buttonSubtract, e);
                    break;
                case '=':
                    buttonEquals(buttonEqual, e);
                    break;
                case '.':

                    if (buttonPeriod.Enabled == false)
                        break;
                    buttonClick(buttonPeriod, e);
                    break;

                default: 
                    break;

            }
        }
    }
}
