namespace TL.Student.Interfaces
{

    /// </summary>
    public interface IT11
    {
        /// <summary>
        /// Calculates the sequence of the function f for a given number n with a maximum of
        //maxSteps steps in the sequence.
        /// </summary>
        /// <param name="n">The starting number for the sequence</param>
        /// <param name="maxSteps">The maximum number of steps in the sequence</param>
        /// <returns>An array representing the sequence of numbers according to the function
        //f</returns>

        int[] Calculate(int n, int maxSteps);
    }
}