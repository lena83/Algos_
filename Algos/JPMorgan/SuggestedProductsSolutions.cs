using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class SuggestedProductsSolutions
    {
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            Dictionary<string, IList<string>> words = new Dictionary<string, IList<string>>();
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < searchWord.Length; i++)
            {
                s.Append(searchWord[i]);
                if (!words.ContainsKey(s.ToString())) 
                {
                    words.Add(s.ToString(), new List<string>());
                }
                var counter = 0;
                foreach (var product in products)
                {
                    if (counter >= 3) break;
                    if (product.StartsWith(s.ToString()))
                    {
                        counter++;
                        words[s.ToString()].Add(product);
                    }
                }
            }
            return words.Values.ToList();
        }
    }
}
