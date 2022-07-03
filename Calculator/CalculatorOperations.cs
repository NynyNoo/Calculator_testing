using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorOperations
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result;
            if (secondNumber == 0)
                result = 0;
            else
                result = firstNumber / secondNumber;
            return result;

        }
    }
}
