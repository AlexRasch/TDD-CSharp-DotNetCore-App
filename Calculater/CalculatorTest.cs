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
        }

    }
}