using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T17Test
    {
        [Fact]
        public void Solve_FillsPartialMagicSquareCorrectly()
        {
            
            var sut = new T17istoyanov();
            int[][] incompleteMagicSquare = new int[][]
            {
                new int[] { 8, 0, 6 },
                new int[] { 0, 5, 7 },
                new int[] { 4, 9, 2 }
            };

            
            int[][] result = sut.Solve(incompleteMagicSquare);

            
            Assert.True(sut.IsMagic());
        }

        [Fact]
        public void Solve_ThrowsArgumentException_WhenMatrixHasDuplicates()
        {
            
            var sut = new T17istoyanov();
            int[][] invalidMagicSquare = new int[][]
            {
                new int[] { 8, 1, 6 },
                new int[] { 3, 5, 7 },
                new int[] { 4, 3, 2 } 
            };

            
            Assert.Throws<ArgumentException>(() => sut.Solve(invalidMagicSquare));
        }


        
    }
}