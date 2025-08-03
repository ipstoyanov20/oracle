using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T12Test
    {
        [Fact]
        public void Calculate_With1Digit_Returns1()
        {
            var t = new T12istoyanov();
            int result = t.Calculate(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_With2Digits_Returns8()
        {
            var t = new T12istoyanov();
            int result = t.Calculate(2);
            Assert.Equal(8, result);
        }

       
    }
}