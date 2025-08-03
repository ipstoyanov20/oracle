namespace TL.Student.Interfaces
{
    /// <summary>
    /// Сумата на всички числа в интервала от Lo до Hi (включително границите),
    /// които са еднократно произведение на три различни прости множителя.
    /// Пример : Сумата на всички числа в интервала от 1 до 100 е 286 ( 30 + 42 + 66 + 70
    //+ 78 = 286 )
    /// </summary>
    public interface IT07
    {
        /// <summary>
        /// Sets the interval boundaries.
        /// </summary>
        /// <param name="lo">The lower boundary of the interval</param>
        /// <param name="hi">The upper boundary of the interval</param>
        /// <returns>The same object</returns>
        IT07 Interval(int lo, int hi);
        /// <summary>
        /// Calculates the sum of all numbers in the interval from Lo to Hi
        /// that are the product of exactly three distinct prime factors.
        /// </summary>
        /// <returns>The sum of all numbers in the specified interval that are the product of
        //exactly three distinct prime factors</returns>
        int Calculate();
    }
}