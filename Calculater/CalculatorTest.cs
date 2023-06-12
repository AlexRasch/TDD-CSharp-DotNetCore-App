using Domain;

namespace Calculater
{
    public class CalculatorTest
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();

            if(calculator.Sum(2, 2) != 4)
            {
                throw new Exception();
            }

            if (calculator.Subtract(2, 2) != 0)
            {
                throw new Exception();
            }
        }

    }
}