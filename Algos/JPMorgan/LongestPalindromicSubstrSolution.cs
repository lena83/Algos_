using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class LongestPalindromicSubstrSolution
    {
        public static string LongestPalindrome(string s)
        {
            string T = "^#" + string.Join("#", s.ToCharArray()) + "#$";
            int n = T.Length;
            int[] P = new int[n];
            int C = 0, R = 0;

            for (int i = 1; i < n - 1; i++)
            {
                P[i] = (R > i) ? Math.Min(R - i, P[2 * C - i]) : 0;
                while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
                    P[i]++;

                if (i + P[i] > R)
                {
                    C = i;
                    R = i + P[i];
                }
            }

            int max_len = P.Max();
            int center_index = Array.IndexOf(P, max_len);
            return s.Substring((center_index - max_len) / 2, max_len);
        }

        public static string LongestPalindrome_v1(string s)
        {
            var result = "";
            var resultLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int left = i;
                var right = i;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > resultLength)
                    {
                        result = s.Substring(left, right - left + 1);
                        resultLength = right - left + 1;
                    }
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > resultLength)
                    {
                        result = s.Substring(left, right - left + 1);
                        resultLength = right - left + 1;
                    }
                    left--;
                    right++;
                }
            }
            return result;
        }

        
    }
}
