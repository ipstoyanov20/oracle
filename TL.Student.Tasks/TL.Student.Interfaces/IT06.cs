namespace TL.Student.Interfaces
{

    public interface IT06
    {
        /// <summary>
        /// Sets the interval boundaries.
        /// </summary>
        /// <param name="lo">The lower boundary of the interval</param>
        /// <param name="hi">The upper boundary of the interval</param>
        /// <returns>The same object</returns>
        IT06 Interval(int lo, int hi);

        int Calculate();
    }
}