using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T02Test
    {
        [Fact]
        public void Returns_Correct_Fibonaci()
        {
            IT02 c = new T02istoyanov()
                .Limit(10);

            int res = c.Calculate();

            Assert.Equal(10, res);
        }
    }
}