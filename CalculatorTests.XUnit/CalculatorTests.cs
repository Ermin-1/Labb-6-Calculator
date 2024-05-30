using Labb_6_Calculator;
using Xunit;

namespace CalculatorTests.XUnit
{
    public class CalculatorTests
    {
        // Skapa en instans av Calculator
        private readonly Calculator _calculator = new Calculator();

  
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 1, 0)]
        [InlineData(-1, -1, -2)]
        [InlineData(1.5, 2.5, 4)]
        [InlineData(0, 0, 0)]
        public void Add_Returns_Correct_Result(double a, double b, double expected)
        {
            
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

       
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(-1, -1, 0)]
        [InlineData(1.5, 0.5, 1)]
        [InlineData(0, 0, 0)]
        public void Subtract_Returns_Correct_Result(double a, double b, double expected)
        {
          
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

       
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(1.5, 2, 3)]
        [InlineData(0, 5, 0)]
        public void Multiply_Returns_Correct_Result(double a, double b, double expected)
        {
           
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

       
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(1.5, 0.5, 3)]
        [InlineData(0, 5, 0)]
        public void Divide_Returns_Correct_Result(double a, double b, double expected)
        {
         
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

       
        [Fact]
        public void DivideByZero_ThrowsDivideByZeroException()
        {
            //Provar lambda expression
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }
    }
}