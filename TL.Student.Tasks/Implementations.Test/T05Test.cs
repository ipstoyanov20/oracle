using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T05Test
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(5, 1)]
        public void PrimeFactorReturnsCorrectFactorsWith20(int key, int value)
        {
            var t05 = new T05istoyanov();
            Dictionary<int, int> dic = t05.PrimeFactor(20);

            Assert.Equal(value, dic[key]);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        [InlineData(5, 1)]
        public void PrimeFactorReturnsCorrectFactorsWith60(int key, int value)
        {
            var t05 = new T05istoyanov();
            Dictionary<int, int> dic = t05.PrimeFactor(60);

            Assert.Equal(value, dic[key]);
        }
    }
}