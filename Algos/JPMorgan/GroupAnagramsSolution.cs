using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class GroupAnagramsSolution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();

            if (strs.Length == 0)
            {
                return result;
            }

            Dictionary<string,IList<string>> dict = new Dictionary<string, IList<string>>
            {
                { strs[0], new List<string> { } }
            };

            for (int i = 1; i < strs.Length; i++)
            {
                var isAnagram = IsAnagram(dict.Keys.ToList(), strs[i], out var key);
                if (!dict.ContainsKey(strs[i]) && isAnagram)
                {
                    var list = dict[key];
                    list.Add(strs[i]);
                }
                if (dict.ContainsKey(strs[i]) && isAnagram)
                {
                    var list = dict[key];
                    list.Add(strs[i]);
                }

                if (!isAnagram && String.IsNullOrEmpty(key)) 
                { 
                    dict.Add(strs[i], new List<string> { });
                }
            }
           
            foreach (var entry in dict)
            {
                var list = new List<string>
                {
                    entry.Key
                };
                list.AddRange(entry.Value);
                result.Add(list);

            }

            return result;
        }

        public static bool IsAnagram(List<string> anagrams, string s2, out string key)
        {
            var result = false;
            key = String.Empty;

            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char ch in s2)
            {
                if (frequency.ContainsKey(ch))
                { frequency[ch]++; }
                else
                {
                    frequency[ch] = 1;
                }

            }

            foreach (string anagram in anagrams)
            {
                if (String.IsNullOrEmpty(anagram) && !String.IsNullOrEmpty(s2)) { continue; }

                if (anagram.Length != s2.Length)
                {
                    continue;
                }
                Dictionary<char, int> frequencyCopy = frequency;

                Stack<char> chars = new Stack<char>();
                foreach (char c in anagram)
                {
                    chars.Push(c);
                }


                while (chars.Count > 0)
                {
                    var ch = chars.Peek();
                    if (frequency.ContainsKey(ch))
                    {
                        frequency[ch]--;
                        chars.Pop();
                        if (frequency[ch] <= 0) { frequency.Remove(ch); }
                    }
                    else
                    {
                        result = false;
                        break;
                    }

                }
                result = chars.Count == 0;

                if (chars.Count == 0)
                {
                    key = anagram; 
                    break;
                }
            }
           
            return result;
        }

        public static IList<IList<string>> GroupAnagrams_v2(string[] strs)
        {
            // Each group of anagrams will associate with its own hash key
            var dict = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var key = GetHashKey_v2(str); // Calculating hash key
                if (dict.TryGetValue(key, out var value))
                    value.Add(str); // Add word to existing group
                else
                    dict.Add(key, new List<string> { str }); // Create a new group containing current word
            }
            return dict.Values.ToList();
        }

        private static string GetHashKey_v2(string s)
        {
            var letterCount = new Dictionary<char, int>();

            foreach (var letter in s)
            {
                if (char.IsLower(letter))
                {
                    letterCount[letter] = letterCount.GetValueOrDefault(letter) + 1;
                }
            }

            var sortedLetters = letterCount.Keys.ToList();
            sortedLetters.Sort();

            var key = new StringBuilder();
            foreach (var letter in sortedLetters)
            {
                key.Append($"{letter}{letterCount[letter]}");
            }

            return key.ToString();
        }

        private static string GetHashKey(string s)
        {
            // Since word can contain only lowercase English letters we can do this trick.
            // You need to learn it because it's pretty regular and useful.
            // Creating an char[26] array for counting letters of the word.
            var key = new char[26];
            foreach (var letter in s)
                key[letter - 'a']++; // This is heart of the trick.
            return new string(key);
        }
    }
}
