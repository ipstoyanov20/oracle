namespace TL.Student.Interfaces
{

    public interface IT01
    {
        /// <summary>
        /// Adds a divisor.
        /// </summary>
        /// <param name="x">The divisor</param>
        /// <returns>The same object</returns>
        IT01 Multiple(int x);
        /// <summary>
        /// Sets the interval boundaries.
        /// </summary>
        /// <param name="lo">The lower boundary of the interval</param>
        /// <param name="hi">The upper boundary of the interval</param>
        /// <returns>The same object</returns>
        IT01 Interval(int lo, int hi);
        /// <summary>
        /// Calculates the sum of numbers in the interval from Lo to Hi that are multiples of X1 or
        ///X2 or … or XN.
        /// </summary>
        /// <returns>The sum of numbers in the specified interval</returns>
        int Calculate();
    }
}