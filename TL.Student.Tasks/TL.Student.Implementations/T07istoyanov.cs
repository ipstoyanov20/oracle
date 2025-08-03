using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T07istoyanov : IT07
    {
        //Направих две променливи за интервала
        private int lo;
        private int hi;
        public IT07 Interval(int lo, int hi)
        {
            this.lo = lo;
            this.hi = hi;

            return this;
        }


        public int Calculate()
        {
            int sum = 0;
            for (int number = lo; number <= hi; number++)
            {
                int largestPrime = FindExactThreeDistinctPrimes(number);
                sum += largestPrime;
            }

            return sum;
        }
        private int FindExactThreeDistinctPrimes(int aNumberFromInterval)
        {
            int originalNum = aNumberFromInterval;
            if (aNumberFromInterval < 2) return 0;

            Dictionary<int, int> dic = new();


            while (aNumberFromInterval % 2 == 0)
            {
                if (dic.ContainsKey(2))
                    dic[2]++;
                else
                    dic[2] = 1;

                aNumberFromInterval /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(aNumberFromInterval); i += 2)
            {
                while (aNumberFromInterval % i == 0)
                {
                    if (dic.ContainsKey(i))
                        dic[i]++;
                    else
                        dic[i] = 1;
                    aNumberFromInterval /= i;
                }
            }
            if (aNumberFromInterval > 2)
            {
                if (dic.ContainsKey(aNumberFromInterval))
                    dic[aNumberFromInterval]++;
                else
                    dic[aNumberFromInterval] = 1;
            }

            if (dic.Keys.Count == 3 && dic.Values.Sum() == 3)
                return originalNum;

            return 0;
        }
    }
}
