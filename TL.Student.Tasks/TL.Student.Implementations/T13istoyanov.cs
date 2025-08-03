using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T13istoyanov : IT13
    {
        public int ClearFrom5and2(int n)
        {
            while (n % 2 == 0)
                n /= 2;
            while (n % 5 == 0)
                n /= 5;

            return n;
        }


        public int FindBiggestPeriod(int n)
        {
            int reminder = 10 % n;
            int period = 1;
            while (reminder != 1)
            {
                reminder = (reminder * 10) % n;
                period++;

                if (period > n) return 0;
            }

            return period;

        }


        public int Calculate()
        {
            int maxPeriod = 0;
            int numberWithBiggestPeriod = 0;
            for (int i = 2; i <= 1000; i++)
            {
                int cleared = ClearFrom5and2(i);
                if (cleared == 1) continue;
                int period = FindBiggestPeriod(cleared);

                if (period > maxPeriod)
                {
                    maxPeriod = period;
                    numberWithBiggestPeriod = i;
                }

            }
            return numberWithBiggestPeriod;
        }

    }
}
