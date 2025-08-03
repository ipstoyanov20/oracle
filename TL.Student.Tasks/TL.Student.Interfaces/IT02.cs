namespace TL.Student.Interfaces
{
    /// <summary>
    /// Сумата на нечетните Fibonacci числа по-малки или равни на X.
    /// X е цяло положително число и се задава като параметър.
    /// Fibonacci числа: 0, 1, 1, 2, 3, 5, 8, …, i+2, …, където i+2 = (i+1) + i
    /// Пример : Сумата на нечетните Fibonacci числа по малки от 10 е 10 ( 1 + 1 + 3 + 5
    //= 10 ).
    /// За Fibonacci виж: https://en.wikipedia.org/wiki/Fibonacci_sequence
    /// </summary>
    public interface IT02
    {
        /// <summary>
        /// Sets the upper limit for Fibonacci sequence calculation.
        /// </summary>
        /// <param name="limit">The upper limit for the Fibonacci sequence</param>
        /// <returns>The same object</returns>
        IT02 Limit(int limit);
        /// <summary>
        /// Calculates the sum of odd Fibonacci numbers less than or equal to the specified limit.
        /// </summary>
        /// <returns>The sum of odd Fibonacci numbers less than the specified limit</returns>
        int Calculate();
    }
}