using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class PalindromeNumberSolution
    {
        public static bool IsPalindrome(int x)
        {
            if (Int32.IsNegative(x)) return false;

            var s = x.ToString();
            var firstHalf = s.Substring(0, s.Length / 2);
            var secondHalf = s.Substring(s.Length / 2 + 1);
            if (s.Length % 2 == 0)
            {
                secondHalf = s.Substring(s.Length / 2);
            }
           
            var reversed = new string(secondHalf.Reverse().ToArray());

            return firstHalf.Equals(reversed);


        }
    }
}
