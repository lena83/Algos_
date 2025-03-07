using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class BreakPalindromeSolution
    {
        public static string BreakPalindrome(string palindrome)
        {
            if (string.IsNullOrEmpty(palindrome) || palindrome.Length <= 1)
                return "";

            StringBuilder sb = new StringBuilder(palindrome);

            for (int i = 0; i < palindrome.Length / 2; ++i)
                if (sb[i] != 'a')
                {
                    sb[i] = 'a';

                    return sb.ToString();
                }

            sb[sb.Length - 1] = 'b';

            return sb.ToString();
        }

      
    }
}
