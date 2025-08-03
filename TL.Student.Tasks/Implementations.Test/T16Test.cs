using TL.Student.Interfaces;
using TL.Student.Implementations;
namespace Implementations.Test
{
    public class T16Test
    {
        private readonly int[][] originalSquare = new int[][]
        {
            new int[] { 8, 1, 6 },
            new int[] { 3, 5, 7 },
            new int[] { 4, 9, 2 }
        };

        [Fact]
        public void Randomize_ReturnsSquareMatrix_WithSameDimensions()
        {
            var sut = new T16istoyanov();

            int[][] randomized = sut.Randomize(originalSquare, seed: 42);

            Assert.NotNull(randomized);
            Assert.Equal(originalSquare.Length, randomized.Length);

            foreach (var row in randomized)
            {
                Assert.NotNull(row);
                Assert.Equal(originalSquare.Length, row.Length);
            }
        }

        [Fact]
        public void Randomize_MultipliesAllElementsBySameMultiplier_IgnoringPositions()
        {
            var sut = new T16istoyanov();
            int multiplier = 3;

            int[][] randomized = sut.Randomize(originalSquare, seed: 42);
            
           
            Assert.NotNull(randomized);
            Assert.Equal(originalSquare.Length, randomized.Length);
            foreach (var row in randomized)
            {
                Assert.NotNull(row);
                Assert.Equal(originalSquare.Length, row.Length);
            }
            
            
            for (int i = 0; i < originalSquare.Length; i++)
            {
                for (int j = 0; j < originalSquare[i].Length; j++)
                {
                    Assert.Equal(originalSquare[i][j] * multiplier, randomized[i][j]);
                }
            }
        }


        
    }
}