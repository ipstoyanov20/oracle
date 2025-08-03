using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T15istoyanov : IT15
    {
        private static void IsValidMatrices(int[][] ms1, int[][] ms2)
        {
            if (ms1 == null)
                throw new ArgumentNullException("Matrix ms1 cannot be null");
            if (ms2 == null)
                throw new ArgumentNullException("Matrix ms2 cannot be null");
            if (ms1.Length == 0)
                throw new ArgumentException("Matrix ms1 cannot be empty");
            if (ms2.Length == 0)
                throw new ArgumentException("Matrix ms2 cannot be empty");

            if (ms1.Length != ms1[0].Length || ms2.Length != ms2[0].Length ||
                ms1.Length != ms2.Length || ms2[0].Length != ms1[0].Length)
            {
                throw new ArgumentException("Matrices are not valid squares or have different dimensions");
            }
            
            var ms2Elements = ms2.SelectMany(row => row).ToList();
            var ms1Elements = ms1.SelectMany(row => row).ToList();

            if (ms1Elements.Count != ms1Elements.Distinct().Count())
                throw new ArgumentException("Matrix ms1 contains duplicate elements. Not a valid magic square.");

            if (ms2Elements.Count != ms2Elements.Distinct().Count())
                throw new ArgumentException("Matrix ms2 contains duplicate elements. Not a valid magic square.");
        }

        public static bool IsMagic(int[][] ms1, int[][] ms2)
        {
            IsValidMatrices(ms1, ms2);

            int size = ms1.Length;

            List<int> rowSumsMs1 = Enumerable.Repeat(0, size).ToList();
            List<int> colSumsMs1 = Enumerable.Repeat(0, size).ToList();
            int diagSumMs1 = 0;
            int antiDiagSumMs1 = 0;

            List<int> rowSumsMs2 = Enumerable.Repeat(0, size).ToList();
            List<int> colSumsMs2 = Enumerable.Repeat(0, size).ToList();
            int diagSumMs2 = 0;
            int antiDiagSumMs2 = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    rowSumsMs1[row] += ms1[row][col];
                    colSumsMs1[col] += ms1[row][col];

                    rowSumsMs2[row] += ms2[row][col];
                    colSumsMs2[col] += ms2[row][col];
                }
            }

            for (int i = 0; i < size; i++)
            {
                diagSumMs1 += ms1[i][i];
                antiDiagSumMs1 += ms1[i][size - 1 - i];

                diagSumMs2 += ms2[i][i];
                antiDiagSumMs2 += ms2[i][size - 1 - i];
            }

            bool isMs1Magic = rowSumsMs1.All(s => s == rowSumsMs1[0]) &&
                              colSumsMs1.All(s => s == colSumsMs1[0]) &&
                              diagSumMs1 == rowSumsMs1[0] &&
                              antiDiagSumMs1 == rowSumsMs1[0];

            bool isMs2Magic = rowSumsMs2.All(s => s == rowSumsMs2[0]) &&
                              colSumsMs2.All(s => s == colSumsMs2[0]) &&
                              diagSumMs2 == rowSumsMs2[0] &&
                              antiDiagSumMs2 == rowSumsMs2[0];

            return isMs1Magic && isMs2Magic;
        }

        public bool IsTheSameWithoutRotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[row][col])
                        return false;
                }
            }

            return true;
        }
        public bool IsTheSameAfterYAxisRotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[row][size - 1 - col])
                        return false;
                }
            }

            return true;
        }

        public bool IsTheSameAfterXAxisRotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[size - 1 - row][col])
                        return false;
                }
            }

            return true;
        }

        public bool IsTheSameAfterMainDiogonalRotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[col][row])
                        return false;
                }
            }

            return true;
        }

        public bool IsTheSameAfterSecondDiagonalRotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[size - 1 - col][size - 1 - row])
                        return false;
                }
            }

            return true;
        }

        public bool IsSameAfter90Rotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[col][size - 1 - row])
                        return false;
                }
            }

            return true;
        }

        public bool IsSameAfter180Rotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[size - 1 - row][size - 1 - col])
                        return false;
                }
            }

            return true;
        }

        public bool IsSameAfter270Rotation(int[][] ms1, int[][] ms2)
        {
            int size = ms1.Length;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (ms1[row][col] != ms2[size - 1 - col][row])
                        return false;
                }
            }

            return true;
        }


        // public bool IsTheSameAfterAllRotations(int[][] ms1, int[][] ms2)
        // {
        //     return IsTheSameWithoutRotation(ms1, ms2) ||
        //            IsTheSameAfterYAxisRotation(ms1, ms2) ||
        //            IsTheSameAfterXAxisRotation(ms1, ms2) ||
        //            IsTheSameAfterMainDiogonalRotation(ms1, ms2) ||
        //            IsTheSameAfterSecondDiagonalRotation(ms1, ms2) ||
        //            IsSameAfter90Rotation(ms1, ms2) ||
        //            IsSameAfter180Rotation(ms1, ms2) ||
        //            IsSameAfter270Rotation(ms1, ms2);
        // }
        
        public bool IsTheSameAfterAllRotations(int[][] ms1, int[][] ms2)
        {
            if (IsTheSameWithoutRotation(ms1, ms2)) 
            {
                Console.WriteLine("Match: No rotation");
                return true;
            }
            if (IsTheSameAfterYAxisRotation(ms1, ms2))
            {
                Console.WriteLine("Match: Y-axis rotation");
                return true;
            }
            if (IsTheSameAfterXAxisRotation(ms1, ms2))
            {
                Console.WriteLine("Match: X-axis rotation");
                return true;
            }
            if (IsTheSameAfterMainDiogonalRotation(ms1, ms2))
            {
                Console.WriteLine("Match: Main diagonal rotation");
                return true;
            }
            if (IsTheSameAfterSecondDiagonalRotation(ms1, ms2))
            {
                Console.WriteLine("Match: Second diagonal rotation");
                return true;
            }
            if (IsSameAfter90Rotation(ms1, ms2))
            {
                Console.WriteLine("Match: 90 degree rotation");
                return true;
            }
            if (IsSameAfter180Rotation(ms1, ms2))
            {
                Console.WriteLine("Match: 180 degree rotation");
                return true;
            }
            if (IsSameAfter270Rotation(ms1, ms2))
            {
                Console.WriteLine("Match: 270 degree rotation");
                return true;
            }

            return false;
        }



        public bool Value(int[][] ms1, int[][] ms2)
        {
            var result = IsMagic(ms1, ms2) && IsTheSameAfterAllRotations(ms1, ms2);
            return result;
        }
    }
}