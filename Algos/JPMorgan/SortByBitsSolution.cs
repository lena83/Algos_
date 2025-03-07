using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class SortByBitsSolution
    {
        public static int[] SortByBits(int[] arr)
        {
            var result = new int[arr.Length];
            SortedDictionary<int, List<int>> sorted = [];

            foreach (int i in arr)
            {
                var count = CountBits(i);

                if (!sorted.ContainsKey(count))
                {
                    sorted.Add(count, [i]);
                }
                else
                {
                    sorted[count].Add(i);
                    sorted[count].Sort();
                }
               
            }

            int j = 0;
            foreach(var keyValue in sorted)
            {
                var values = keyValue.Value;
                 foreach(var value in values)
                {
                    result[j] = value;
                    j++;
                }
            }
          
            return result;
        }

        public static int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                    count++;
                n /= 2;
            }
            return count;
        }
    }
}
