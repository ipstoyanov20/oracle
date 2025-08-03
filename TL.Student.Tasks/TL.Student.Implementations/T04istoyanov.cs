
using System.Data;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T04istoyanov : IT04
    {
        private int lo;
        private int hi;
        public IT04 Interval(int lo, int hi)
        {
            if (lo > hi) throw new ArgumentException("Invalid range");

            this.lo = lo;
            this.hi = hi;

            return this;
        }

        public int Calculate()
        {
            int sum = 0;
            for (int i = lo + 1; i < hi; i++)
            {

                int num = i;
                int origin = i;
                int empty = 0;
                while (num > 0)
                {
                    empty = empty * 10 + (num % 10);
                    num /= 10;

                }
                if (origin == empty)
                    sum += i;
            }

            return sum;
        }


    }
}
