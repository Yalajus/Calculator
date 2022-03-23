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
        
        public Calculator()
        {
            InitializeComponent();

        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Text = "";
            isOperationPerformed = false;
            Button button = (Button) sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            isOperationPerformed = true;
            resultValue = Convert.ToDouble(textBoxResult.Text);

            label1.Text = textBoxResult.Text + " " + operationPerformed;
        }

        private void buttonEquals(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    resultValue = resultValue + Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    break;
                case "-":
                    resultValue = resultValue - Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    break;
                case "*":
                    resultValue = resultValue * Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
                    break;
                case "/":
                    resultValue = resultValue / Convert.ToDouble(textBoxResult.Text);
                    textBoxResult.Text = Convert.ToString(resultValue);
                    label1.Text = "";
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
            textBoxResult.Text = "";
            resultValue = 0;
            label1.Text = "";
        }
    }
}
