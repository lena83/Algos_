using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class FindLeastNumOfUniqueIntsSolution
    {
        public static int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            //use dictionary

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            var minHeap = new PriorityQueue<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!frequency.ContainsKey(arr[i]))
                {
                    frequency.Add(arr[i], 1);
                }
                else
                {
                    frequency[arr[i]]++;
                }
            }

            foreach (var key in frequency.Keys)
            {
                minHeap.Enqueue(key, frequency[key]);
            }

            while (k >0 && minHeap.Count !=0)
            {
                var val = minHeap.Peek();
                if (frequency.ContainsKey(val))
                {
                    frequency[val]--;
                    if (frequency[val] == 0)
                    {
                        minHeap.Dequeue();
                        frequency.Remove(val);
                    }
                }
                k--;
            }

            return frequency.Count;
        }
    }
}
