namespace TL.Student.Interfaces
{
    /// <summary>
    /// Кои е номера на е първото Fibonacci число с поне X цифри.
    /// X е цяло положително число и се задава като параметър.
    /// Пример : първото число с 3 цифри е 13-тото Fibonacci число.
    /// Fibonacci числа : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, …, i+2, … , където i+2 =
    //(i+1) + i
    /// За Fibonacci виж : https://en.wikipedia.org/wiki/Fibonacci_sequence
    /// </summary>
    public interface IT12
    {
        /// <summary>
        /// Calculates the index of the first Fibonacci number that has at least n digits.
        /// </summary>
        /// <param name="n">The minimum number of digits</param>
        /// <returns>The index of the first Fibonacci number with at least n digits</returns>
        int Calculate(int n);
    }
}