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
    public partial class Form1 : Form
    {
        public double firstNumber = 0;
        public double secondNumber = 0;
        public Form1()
        {
            InitializeComponent();
            firstNumber = 0;
            secondNumber = 0;
        }
        private void firstNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            firstNumber = double.Parse(firstNumber_TextBox.Text);
        }

        private void secondNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            secondNumber = double.Parse(secondNumber_TextBox.Text);
        }
        private void add_Button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = (CalculatorOperations.Add(firstNumber, secondNumber)).ToString();
        }

        private void subtrack_Button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = (CalculatorOperations.Subtract(firstNumber, secondNumber)).ToString();
        }

        private void divide_Button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = (CalculatorOperations.Divide(firstNumber, secondNumber)).ToString();
        }

        private void multiply_Button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = (CalculatorOperations.Multiply(firstNumber, secondNumber)).ToString();
        }
    }
}
