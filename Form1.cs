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
        public Calculator()
        {
            InitializeComponent();

        }

        public void addition_Click(object sender, EventArgs e)
        {
            var first = Convert.ToInt32(numberOne.Text);
            var second = Convert.ToInt32(numberTwo.Text);

            Result.Text = Convert.ToString(Addition(first, second));
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            var first = Convert.ToInt32(numberOne.Text);
            var second = Convert.ToInt32(numberTwo.Text);

            Result.Text = Convert.ToString(Subtraction(first, second));
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            var first = Convert.ToInt32(numberOne.Text);
            var second = Convert.ToInt32(numberTwo.Text);

            Result.Text = Convert.ToString(Multiplication(first, second));
        }

        private void division_Click(object sender, EventArgs e)
        {
            var first = Convert.ToInt32(numberOne.Text);
            var second = Convert.ToInt32(numberTwo.Text);

            Result.Text = Convert.ToString(Division(first, second));
        }

        public int Addition(int a, int b)
        {
            int result;

            result = a + b;

            return result;
        }

        public int Subtraction(int a, int b)
        {
            int result;

            result = a - b;

            return result;
        }


        public int Multiplication(int a, int b)
        {
            int result;

            result = a * b;

            return result;
        }


        public int Division(int a, int b)
        {
            int result;

            result = a / b;

            return result;
        }


    }
}
