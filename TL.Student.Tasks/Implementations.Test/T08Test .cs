using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T08Test
    {

        [Fact]
        public void Calculate_ShouldReturnsSpiral4x4Matrix()
        {
            
            IT08 spiral = new T08istoyanov();
            spiral.Init(4, 4);

            int value = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    spiral.Value(i, j, value++);
                }
            }

            
            var result = spiral.Calculate();

            
            int[] expected =
            {
                1, 2, 3, 4,
                8, 12, 16,
                15, 14, 13,
                9, 5, 6, 7,
                11, 10
            };

            Assert.Equal(expected, result);
        }
    }
}