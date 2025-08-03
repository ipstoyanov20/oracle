using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T05istoyanov : IT05
    {
        public Dictionary<int, int> PrimeFactor(int number)
        {
            Dictionary<int, int> numbers = new();


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                while (number % i == 0)
                {
                    if (numbers.ContainsKey(i))
                        numbers[i]++;
                    else
                        numbers[i] = 1;

                    number /= i;
                }
            }
            if (number > 1)
            {

                if (numbers.ContainsKey(number))
                    numbers[number]++;
                else
                    numbers[number] = 1;
            }



            return numbers;
        }

    }
}
