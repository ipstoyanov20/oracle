using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T01Test
    {
        [Fact]
        public void Returns_Correct_Calculate()
        {
            IT01 c = new T01istoyanov()
                .Interval(1, 9)
                .Multiple(3)
                .Multiple(5);
            int res = c.Calculate();

            Assert.Equal(23, res);
        }
    }
}