namespace TL.Student.Interfaces
{
    /// <summary>
    /// Сумата на простите числа в интервала от Lo до Hi (включително границите).
    /// Lo, Hi са цели положителни числа и се задават като параметри.
    /// Пример : сумата на простите числа между 1 и 10 е 17 ( 2 + 3 + 5 + 7 = 17 ).
    /// За прости числи виж: https://en.wikipedia.org/wiki/Prime_number
    /// За "решето на Ератостен" виж : https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
    /// </summary>
    public interface IT03
    {
        /// <summary>
        /// Sets the interval boundaries.
        /// </summary>
        /// <param name="lo">The lower boundary of the interval</param>
        /// <param name="hi">The upper boundary of the interval</param>
        /// <returns>The same object</returns>
        IT03 Interval(int lo, int hi);
        /// <summary>
        /// Calculates the sum of prime numbers in the interval from Lo to Hi.
        /// </summary>
        /// <returns>The sum of prime numbers in the specified interval</returns>
        int Calculate();
    }
}