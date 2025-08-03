namespace TL.Student.Interfaces
{
    /// <summary>
    /// Броя на нулите накрая на factorial от X.
    /// X е цяло положително число и се задава като параметър.
    /// factorial(n) = n! = n * (n - 1) * … * 1
    /// За factorial виж https://en.wikipedia.org/wiki/Factorial
    /// Пример : броя на нулите от накрая на 10! е 2 ( 10! = 3628800 )
    /// </summary>
    public interface IT09
    {
        /// <summary>
        /// Sets the limit for the factorial calculation.
        /// </summary>
        /// <param name="limit">The limit to set</param>
        /// <returns>The same object</returns>
        IT09 Limit(int limit);
        /// <summary>
        /// Calculates the number of trailing zeros in the factorial of the set limit.
        /// </summary>
        /// <returns>The number of trailing zeros in the factorial of the set limit</returns>
        int Calculate();
    }
}