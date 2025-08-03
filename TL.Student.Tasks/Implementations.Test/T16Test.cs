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
            var ince = new T16istoyanov();

            int[][] randomized = ince.Randomize(originalSquare, seed: 42);

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
            var ince = new T16istoyanov();

            int[][] randomized = ince.Randomize(originalSquare, seed: 42);

            var lastRotated = ince.LastRotatedMatrix;
            int multiplier = ince.Multiplier;
            
            for (int i = 0; i < lastRotated.Length; i++)
            {
                for (int j = 0; j < lastRotated[i].Length; j++)
                {
                    Assert.Equal(lastRotated[i][j] * multiplier, randomized[i][j]);
                }
            }
        }


        
    }
}