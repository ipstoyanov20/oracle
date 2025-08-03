
using System.Diagnostics.CodeAnalysis;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T02istoyanov : IT02
    {
        private int limit;
        public IT02 Limit(int limit)
        {
            if (limit < 0) throw new ArgumentException("Should be positive number");
            this.limit = limit;
            return this;
        }

        public int Calculate()
        {
            return SumOddInFib(0, 1);
        }
        public int SumOddInFib(int prev, int curr)
        {
            if (curr > limit) return 0;
            int odd = (curr % 2 != 0) ? curr : 0;
            int next = prev + curr;
            return odd + SumOddInFib(curr, next);
        }
    }
}
