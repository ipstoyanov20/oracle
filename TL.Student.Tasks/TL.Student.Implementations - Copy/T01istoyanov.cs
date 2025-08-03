using TL.Student.Interfaces;

namespace TL.Student.Implementations;

public class T01istoyanov : IT01
{
    private readonly List<int> divisors = new List<int>();
    private int lo;
    private int hi;
    public IT01 Multiple(int x)
    {
        if (x <= 0)
            throw new ArgumentException("");
        if (!divisors.Contains(x))
            divisors.Add(x);

        return this;
    }
    /// <summary>
    /// Sets the interval boundaries.
    /// </summary>
    /// <param name="lo">The lower boundary of the interval</param>
    /// <param name="hi">The upper boundary of the interval</param>
    /// <returns>The same object</returns>
    public IT01 Interval(int lo, int hi)
    {
        if (lo > hi) throw new ArgumentException("Invalid range");
        this.lo = lo;
        this.hi = hi;

        return this;
    }
    /// <summary>
    /// Calculates the sum of numbers in the interval from Lo to Hi that are multiples of X1 or
    ///X2 or … or XN.
    /// </summary>
    /// <returns>The sum of numbers in the specified interval</returns>
    public int Calculate()
    {
        int sum = 0;
        for (int i = lo; i <= hi; i++)
        {
            foreach (var item in divisors)
            {
                if (i % item == 0)
                {

                    sum += i;
                    break;
                }
            }
        }
        return sum;
    }
}