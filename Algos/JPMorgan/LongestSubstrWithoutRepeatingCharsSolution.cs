using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class LongestSubstrWithoutRepeatingCharsSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (String.IsNullOrEmpty(s)) return  0;
            if (s.Length == 1) return 1;
            Dictionary<string, int> substrPostions = new Dictionary<string, int>();
            StringBuilder subStr = new StringBuilder();

            for (int i = 0; i <s.Length; i++)
            {
                if (!subStr.ToString().Contains(s[i]))
                {
                    subStr.Append(s[i]);
                }
                else
                {
                    if (subStr.Length > 0)
                    {
                        substrPostions.TryAdd(subStr.ToString(), i - subStr.Length);
                        i = i - subStr.Length;
                        subStr.Clear();
                    }
                }
            }

            if (subStr.Length > 0)
            {
                substrPostions.TryAdd(subStr.ToString(), 0);
            }
            var length = substrPostions.Keys.MaxBy(x => x.Length)?.Length;
            return  (int)length;
        }

        public static int LengthOfLongestSubstring_v2(string s)
        {
            var lst = new HashSet<int>();
            int window = 0, max = 0, left = 0, right = 0;

            while (right < s.Length)
            {
                if (lst.Contains(s[right]))
                {
                    lst.Remove(s[left]);
                    left++;
                }
                else
                {
                    lst.Add(s[right]);
                    window = right - left + 1;
                    max = max > window ? max : window;
                    right++;
                }

            }

            return max;
        }
    }
}
