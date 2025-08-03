using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Student.Interfaces;

namespace TL.Student.Implementations
{
    public class T09istoyanov : IT09
    {
        
        private int limit;
        public IT09 Limit(int limit)
        {
            this.limit = limit;
            return this;
        }
        
        public int Calculate()
        {
            
            int count = 0;
            for (int i = 5; limit / i >= 1; i *= 5)
            {
                count += limit / i; 
            }
            return count;
        }
        
    }
}
