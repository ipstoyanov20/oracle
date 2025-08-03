
using System.Data;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T03istoyanov : IT03
    {
        private int lo;
        private int hi;
        public IT03 Interval(int lo, int hi)
        {
            if (lo > hi) throw new ArgumentException("Invalid range");

            this.lo = lo;
            this.hi = hi;

            return this;
        }

        public int Calculate()
        {
            int sum = 0;
            for (int i = lo; i <= hi; i++)
            {
                if (i < 2) continue;
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {

                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                    sum += i;
            }
            if (sum == 0)
                throw new ArgumentException("No prime");

            return sum;
        }


    }
}
