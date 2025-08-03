using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T12istoyanov : IT12
    {
        public int Calculate(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("The number of digits must be a positive integer.");
            }
            for(int i = 0; i < int.MaxValue; i++)
            {
                if (Fibonacci(i).ToString().Length >= n)
                {
                    return i + 1;
                }
            }
            return -1; 
            
        }
        private long Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be a non-negative integer.");
            }
            if (n == 0) return 0;
            if (n == 1) return 1;

           return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
        
        
    }
}
