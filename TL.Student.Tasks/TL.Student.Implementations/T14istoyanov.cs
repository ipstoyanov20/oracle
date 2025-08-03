using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T14istoyanov : IT14
    {
        private List<int> listForSpecificNumbers = new();

        int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
        public List<int> Calculate()
        {

            for (int i = 1; i <= 5000; i++)
            {
                int sum = 0;
                var number = i.ToString();
                foreach (var ch in number)
                {

                    sum += Factorial(int.Parse(ch.ToString()));

                }
                if (i == sum)
                    listForSpecificNumbers.Add(i);

            }

            return listForSpecificNumbers;

        }
    }
}
