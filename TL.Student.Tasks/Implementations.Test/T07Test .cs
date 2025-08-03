using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T07Test
    {

        [Fact]
        public void Returns_Correct_Sum_Of_ExactThreePrime()
        {
            IT06 c = new T06istoyanov()
                .Interval(1, 10);

            int res = c.Calculate();

            Assert.Equal(32, res);
        }
    }
}