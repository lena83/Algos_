using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class UglyNumberSolution
    {
        public static bool IsUgly(int n)
        {
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                if (n % 3 == 0)
                {
                    n /= 3;
                }
                if (n % 5 == 0)
                {
                    n /= 5;
                }
                if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
                { 
                    continue;
                }
                else 
                { 
                    break;
                }
            }
            return n == 1;
        }
           
      
        
    }
}
