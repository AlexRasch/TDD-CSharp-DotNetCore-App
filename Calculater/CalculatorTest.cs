using Domain;

namespace Calculater
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_Sum_AddsTwoNumbers()
        {
            var calculator = new Calculator();
            int left = 2;
            int right = 2;
            int expected = 4;

            // Act
            int actual = calculator.Sum(left, right);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_Subtract_SubtractsTwoNumbers()
        {
            var calculator = new Calculator();
            int left = 2;
            int right = 2;
            int expected = 0;

            // Act
            int actual = calculator.Subtract(left, right);

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}