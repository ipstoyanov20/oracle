using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T11istoyanov : IT11
    {
       public int[] Calculate(int n, int maxSteps)
        {
            
            List<int> list = new List<int>();
            int number = n;

            for (int steps = 0; steps < maxSteps; steps++)
            {
                list.Add(number);
                if (number == 1)
                {
                    break;
                }
                else if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1;
                }
            }

            return list.ToArray();
        }
    }
}
