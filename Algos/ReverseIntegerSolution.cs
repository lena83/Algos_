using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class ReverseIntegerSolution
    {
        public static int Reverse(int x)
        {
            StringBuilder sb = new StringBuilder();
            bool isNegative = Int32.IsNegative(x);
            var xStr = x.ToString();
            int result = 0;
            if (isNegative) 
            {
                for (int i = xStr.Length - 1; i >= 1; i--)
                {
                    sb.Append(xStr[i]);
                }
                sb.Insert(0, "-");
                
            }
            else
            {
                for (int i = xStr.Length - 1; i >= 0; i--)
                {
                    sb.Append(xStr[i]);
                }
            }
            var parsed = Int32.TryParse(sb.ToString(), out x);
            if (parsed) result = x;
            return result;
        }
    }
}
