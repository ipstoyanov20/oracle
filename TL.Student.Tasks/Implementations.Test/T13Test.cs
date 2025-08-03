using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T13Test
    {
        

        [Fact]
        public void Calculate_ReturnsKnownLongestPeriod()
        {
            var task = new T13istoyanov();

            int result = task.Calculate();

            Assert.Equal(983, result); 
        }
       
    }
}