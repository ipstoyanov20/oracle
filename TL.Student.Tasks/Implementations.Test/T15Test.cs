using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T15Test
    {
        private readonly int[][] magicSquare = new int[][]
        {
            new int[] { 8, 1, 6 },
            new int[] { 3, 5, 7 },
            new int[] { 4, 9, 2 }
        };
        
        private readonly int[][] magicSquare2 = new int[][]
        {
            new int[] {16, 3, 2, 13},
            new int[] {5, 10, 11, 8},
            new int[] {9, 6, 7, 12},
            new int[] {4, 15, 14, 1}
        };

        private readonly int[][] rotated90Square = new int[][]
        {
            new int[] { 4, 3, 8 },
            new int[] { 9, 5, 1 },
            new int[] { 2, 7, 6 }
        };

        [Fact]
        public void Value_ReturnsTrue_ForRotationEquivalentSquares()
        {
            var sut = new T15istoyanov();

            bool result = sut.Value(magicSquare, rotated90Square);

            Assert.True(result);
        }

        [Fact]
        public void Value_ReturnsFalse_ForDifferentSquares()
        {
            var sut = new T15istoyanov();

            int[][] differentSquare = new int[][]
            {
                new int[] {1, 12, 8, 13},
                new int[] {14, 7, 11, 4},
                new int[] {15, 6, 10, 3},
                new int[] {2, 9, 5, 16}
            };

            bool result = sut.Value(magicSquare2, differentSquare);

            Assert.False(result);
        }

        
    }
}