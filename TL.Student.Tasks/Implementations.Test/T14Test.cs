using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T14Test
    {
        

        [Fact]
        public void Calculate_ReturnsExpectedNumbers()
        {
            var sut = new T14istoyanov();

            List<int> result = sut.Calculate();

            var expected = new List<int> { 1, 2, 145 };

            Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
        }

        [Fact]
        public void Calculate_AllNumbersMatchSumOfDigitFactorials()
        {
            var sut = new T14istoyanov();

            var result = sut.Calculate();

            foreach (var number in result)
            {
                int sum = 0;
                foreach (var ch in number.ToString())
                {
                    int digit = ch - '0';
                    int fact = 1;
                    for (int i = 2; i <= digit; i++)
                        fact *= i;

                    sum += fact;
                }

                Assert.Equal(number, sum);
            }
        }
       
    }
}