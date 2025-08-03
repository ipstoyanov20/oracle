using System;
using System.Collections.Generic;
using System.Linq;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T16istoyanov : IT16
    {
        public int[][] LastRotatedMatrix { get; private set; }

        public int Multiplier { get; set; }

        private void IsValidMatrix(int[][] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException( "Matrix cannot be null");
            if (matrix.Length == 0 || matrix.Any(row => row == null || row.Length != matrix.Length))
                throw new ArgumentException("Matrix must be non-empty and square");
            
            var ms1Elements = matrix.SelectMany(row => row).ToList();

            if (ms1Elements.Count != ms1Elements.Distinct().Count())
                throw new ArgumentException("Matrix ms1 contains duplicate elements. Not a valid magic square.");
        }

        private void ToRotateYAxis(int[][] matrix)
        {
            foreach (var row in matrix)
                Array.Reverse(row);
        }

        private void ToRotateXAxis(int[][] matrix)
        {
            Array.Reverse(matrix);
        }

        private void ToRotateMainDiagonal(int[][] matrix)
        {
            int size = matrix.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                }
            }
        }

        private void ToRotateSecondDiagonal(int[][] matrix)
        {
            int size = matrix.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    int x1 = i, y1 = j;
                    int x2 = size - 1 - j, y2 = size - 1 - i;
                    
                    matrix[x1][y1] = matrix[x2][y2];
                    matrix[x2][y2] = matrix[x1][y1];
                }
            }
        }

        private void ToRotate90(int[][] matrix)
        {
            ToRotateMainDiagonal(matrix);
            ToRotateYAxis(matrix);
        }

        private void ToRotate180(int[][] matrix)
        {
            ToRotateXAxis(matrix);
            ToRotateYAxis(matrix);
        }

        private void ToRotate270(int[][] matrix)
        {
            ToRotateMainDiagonal(matrix);
            ToRotateXAxis(matrix);
        }

        public int[][] Randomize(int[][] ms, int seed)
        {
            IsValidMatrix(ms);
            int size = ms.Length;
            int[][] result = ms.Select(row => row.ToArray()).ToArray();

            Random rand = new Random(seed);
            List<Action<int[][]>> rotations = new List<Action<int[][]>>
            {
                ToRotateXAxis,
                ToRotateYAxis,
                ToRotateMainDiagonal,
                ToRotateSecondDiagonal,
                ToRotate90,
                ToRotate180,
                ToRotate270
            };

            
            int rotationsCount = rand.Next(0, rotations.Count + 1);
            for (int i = 0; i < rotationsCount; i++)
            {
                int op = rand.Next(rotations.Count);
                rotations[op](result);
            }
            LastRotatedMatrix = result.Select(row => row.ToArray()).ToArray();

            int multiplier = rand.Next(1, 6);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    result[row][col] *= multiplier;
                }

            }
            Multiplier = multiplier;
            return result;
        }
    }
}
