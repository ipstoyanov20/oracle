using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T11Test
    {
        [Fact]
        public void Calculate_From7_WithMaxSteps10_ShouldReturnCorrectCollatzSequence()
        {
            var collatz = new T11istoyanov();
            int n = 7;
            int maxSteps = 10;
            
            var result = collatz.Calculate(n, maxSteps);
            
            var expected = new int[] { 7, 22, 11, 34, 17, 52, 26, 13, 40, 20 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_From6_WithMaxSteps10_ShouldReturnEarlyStopAt1()
        {
            var collatz = new T11istoyanov();
            int n = 6;
            int maxSteps = 10;
            
            var result = collatz.Calculate(n, maxSteps);
            
            var expected = new int[] { 6, 3, 10, 5, 16, 8, 4, 2, 1 };
            Assert.Equal(expected, result);
        }

       
    }
}