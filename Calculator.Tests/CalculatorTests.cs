using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(22,3,25)]
        [InlineData(double.MaxValue,20,double.MaxValue)]
        public void Add_SimpleAddToTestCalculate(double x, double y,double expected)
        {
            double actual = CalculatorOperations.Add(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(22, 3, 19)]
        [InlineData(double.MinValue, 20, double.MinValue)]
        public void Add_SimpleSubtractToTestCalculate(double x, double y, double expected)
        {
            double actual = CalculatorOperations.Subtract(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(22, 4, 5.50)]
        [InlineData(22, 0, 0)]
        public void Add_SimpleDivideToTestCalculate(double x, double y, double expected)
        {
            double actual = CalculatorOperations.Divide(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(22, 3, 66)]
        public void Add_SimpleMultiplyToTestCalculate(double x, double y, double expected)
        {
            double actual = CalculatorOperations.Multiply(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
