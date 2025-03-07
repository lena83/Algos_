using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class CheckAlmostEquivalentSolution
    {
        public static bool CheckAlmostEquivalent(string word1, string word2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < word1.Length; i++)
            {
                if (map.ContainsKey(word1[i]))
                {
                    map[word1[i]] += 1;
                }
                else
                {
                    map.Add(word1[i], 1);
                }
                if (map.ContainsKey(word2[i]))
                {
                    map[word2[i]] -= 1;
                }
                else
                {
                    map.Add(word2[i], -1);
                }
            }

            if (map.Values.Max() > 3 || map.Values.Min() < -3)
                return false;

            return true;
        }
    }
}
