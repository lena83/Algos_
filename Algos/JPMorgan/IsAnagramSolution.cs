using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class IsAnagramSolution
    {
        public static bool IsAnagram(string s, string t)
        {
            var hashKeyS = GetHashKey(s);
            var hashKeyT = GetHashKey(t);


            return String.Equals(hashKeyS, hashKeyT);
        }

        public static string GetHashKey(string s)
        {
            SortedDictionary<char,int> frequency = new SortedDictionary<char,int>();
            StringBuilder  sb = new StringBuilder();


            foreach (char c in s)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency.Add(c, 1);
                }
            }

            foreach (var entry in frequency)
            {
                sb.Append($"{entry.Key}{entry.Value}");
            }

            return sb.ToString();
        }
    }
}
