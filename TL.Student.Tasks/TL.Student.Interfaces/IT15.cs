namespace TL.Student.Interfaces
{
    /// <summary>
    /// A magic square is a square matrix of distinct non-negative integers such that the sums of
    //the numbers in each row, column, main diagonal, and secondary diagonal are equal.
    /// Two or more different magic squares are isomorphic if one can be obtained from the
    //other through one or more rotations – for example, around the central horizontal axis, central
    //vertical axis, through the main diagonal, through the secondary diagonal, and others.
    /// Implements a check to determine if two magic squares are isomorphic.
    /// For canonical representation, see: https://en.wikipedia.org/wiki/Canonical_form
    /// </summary>
    public interface IT15
    {
        /// <summary>
        /// Determines if two magic squares are isomorphic.
        /// </summary>
        /// <param name="ms1">First magic square</param>
        /// <param name="ms2">Second magic square</param>
        /// <returns>true if the squares are isomorphic, false otherwise</returns>
        bool Value(int[][] ms1, int[][] ms2);
    }
}