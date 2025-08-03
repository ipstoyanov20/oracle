namespace TL.Student.Interfaces
{
    /// <summary>
    /// Сумата на всички палиндроми в интервала от Lo до Hi (включително границите).
    /// Lo, Hi са цели положителни числа и се задават като параметри.
    /// Пример : Сумата на всички палиндроми по-големи от 10 и по малки или равни на 30
    //е 33 ( 11 + 22 = 33 ).
    /// За палиндром виж : https://en.wikipedia.org/wiki/Palindrome
    /// </summary>
    public interface IT04
    {
        /// <summary>
        /// Sets the interval boundaries.
        /// </summary>
        /// <param name="lo">The lower boundary of the interval</param>
        /// <param name="hi">The upper boundary of the interval</param>
        /// <returns>The same object</returns>
        IT04 Interval(int lo, int hi);
        /// <summary>
        /// Calculates the sum of all palindromes in the interval from Lo to Hi.
        /// </summary>
        /// <returns>The sum of all palindromes in the specified interval</returns>
        int Calculate();
    }
}