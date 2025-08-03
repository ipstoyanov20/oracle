using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T08istoyanov : IT08
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public IT08 Init(int rows, int columns)
        {
            this.rows = rows;
            this.cols = columns;

            matrix = new int[rows, cols];
            return this;
        }

        /// <summary>
        /// Sets a default value for the cells if not explicitly set.
        /// </summary>
        /// <param name="value">Default value for cells</param>
        /// <returns>The same object</returns>
        public IT08 DefaultValue(int value)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = value;
                }
            }

            return this;
        }

        /// <summary>
        /// Sets an explicit value for a specific cell.
        /// </summary>
        /// <param name="iRow">Row index</param>
        /// <param name="iCol">Column index</param>
        /// <param name="value">Value to set</param>
        /// <returns>The same object</returns>
        public IT08 Value(int iRow, int iCol, int value)
        {
            matrix[iRow, iCol] = value;
            return this;
        }

        /// <summary>
        /// Calculates the array of numbers from the matrix following the specified recipe.
        /// </summary>
        /// <returns>An array of numbers from the matrix</returns>
        public int[] Calculate()
        {
            
            List<int> spiral = new();
            int top = 0, left = 0;
            int bottom = rows - 1, right = cols - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    spiral.Add(matrix[top, i]);
                }

                top++;
                for (int i = top; i <= bottom; i++)
                {
                    spiral.Add(matrix[i, right]);
                }

                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        spiral.Add(matrix[bottom, i]);
                    }

                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        spiral.Add(matrix[i, left]);
                    }

                    left++;
                }
            }

            foreach (var i in spiral)
            {
                Console.WriteLine(i);
            }

            int[] updated = spiral.ToArray();
            return updated;
        }
    }
}