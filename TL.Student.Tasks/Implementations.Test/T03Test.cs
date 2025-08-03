using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T03Test
    {
        [Fact]
        public void Returns_Correct_Eratosten()
        {
            IT03 c = new T03istoyanov()
                .Interval(1, 10);

            int res = c.Calculate();

            Assert.Equal(17, res);
        }
    }
}