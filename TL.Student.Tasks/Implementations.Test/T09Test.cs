using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T09Test
    {

        [Theory]
        [InlineData(5, 1)]    
        [InlineData(10, 2)]   
        [InlineData(25, 6)]   
        [InlineData(100, 24)] 
        [InlineData(0, 0)]    
        public void Calculate_Returns_CorrectNumberOfTrailingZeros(int limit, int expected)
        {
            var solver = new T09istoyanov().Limit(limit);
            int result = solver.Calculate();
            Assert.Equal(expected, result);
        }
    }
}