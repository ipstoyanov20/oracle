using System.Collections.Generic;
namespace TL.Student.Interfaces
{
    /// <summary>
    /// Да се разложи на прости множители числото X, X е параметър.
    /// Пример : 20 = 2^2*5 или {2=2,5=1}
    /// Пример : 60 = 2^2*3*5 или {2=2,3=1,5=1}
    /// </summary>
    public interface IT05
    {
        /// <summary>
        /// Decomposes the given number into its prime factors.
        /// </summary>
        /// <param name="number">The number to decompose</param>
        /// <returns>A dictionary where the key is the prime factor and the value is the
        //exponent</returns>
        Dictionary<int, int> PrimeFactor(int number);
    }
}