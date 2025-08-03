using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TL.Student.Interfaces
{
    /// <summary>
    /// A magic square is a square matrix of distinct non-negative integers such that the sums of
    //the numbers in each row, column, main diagonal, and secondary diagonal are equal.
    /// A magic square can be transformed into another by one or more rotations—around the
    //central horizontal axis, central vertical axis, main diagonal, secondary diagonal, etc.
    /// Additionally, all values in a magic square can be multiplied by the same non-negative
    //number.
    /// This interface specifies a method to randomly shuffle a magic square using a seed. Based
    //on the seed, zero or more rotations are applied and all values are reduced by a random
    //number from 1 to 5.
    /// </summary>
    public interface IT16
    {
        /// <summary>
        /// Randomly shuffles a magic square using a specified seed. This can involve rotations
        //and multiplying all values by a random factor from 1 to 5.
        /// </summary>
        /// <param name="ms">The magic square to be randomized</param>
        /// <param name="seed">The seed used for randomization, affecting the randomness of
        //transformations and value reductions</param>
        /// <returns>The randomized magic square</returns>
        int[][] Randomize(int[][] ms, int seed);
    }
}