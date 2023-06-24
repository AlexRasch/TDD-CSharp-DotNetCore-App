using Domain;
using FluentAssertions;

namespace CalculaterTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Sum_of_2_and_2_Should_be_4()
            => new Calculator()
            .Sum(2,2)
            .Should().Be(4);

        [Fact]
        public void Sum_of_4_substract_2_Should_be_2()
            => new Calculator()
            .Subtract(4,2)
            .Should().Be(2);

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