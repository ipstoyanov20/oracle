using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T10istoyanov : IT10
    {
        private int limit;

        public IT10 Limit(int limit)
        {
            this.limit = limit;
            return this;
        }

        public int Calculate()
        {
            int count = 0;

            for (int firstNumerA = 1; firstNumerA < limit; firstNumerA++)
            {
                for (int secondNumerB = firstNumerA; secondNumerB < limit; secondNumerB++)
                {
                    for (int thirdNumerC = secondNumerB + 1; thirdNumerC < limit; thirdNumerC++)
                    {
                        if (firstNumerA * firstNumerA + secondNumerB * secondNumerB == thirdNumerC * thirdNumerC &&
                            firstNumerA + secondNumerB + thirdNumerC <= limit)
                        {
                            count++;
                        }

                    }
                }
            }

            return count;
        }
    }
}