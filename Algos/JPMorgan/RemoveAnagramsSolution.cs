using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class RemoveAnagramsSolution
    {
        public static IList<string> RemoveAnagrams(string[] words)
        {
            int i = 1;
            while (i < words.Length)
            {
                if (IsAnagram(words[i], words[i - 1]))
                {
                    for (int j =i; j <= words.Length - 2; j++)
                    {
                        words[j] = words[j + 1];
                    }
                    Array.Resize(ref words, words.Length - 1);
                    
                }
                else
                {
                    i++;
                }
            }


            return words;
        }

       
        public static bool IsAnagram(string s, string t)
        {
            var hashKeyS = GetHashKey(s);
            var hashKeyT = GetHashKey(t);


            return System.String.Equals(hashKeyS, hashKeyT);
        }

        public static string GetHashKey(string s)
        {
            SortedDictionary<char, int> frequency = new SortedDictionary<char, int>();
            StringBuilder sb = new StringBuilder();


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
