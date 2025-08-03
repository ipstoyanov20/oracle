using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T04Test
    {
        [Fact]
        public void Returns_Correct_Palidrome()
        {
            IT04 c = new T04istoyanov()
                .Interval(10, 30);

            int res = c.Calculate();

            Assert.Equal(33, res);
        }
    }
}