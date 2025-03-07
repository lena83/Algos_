using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class TopKFrequentElementsSolution
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            int[] topKElements = new int[k];
            Dictionary<int,int> elementsFrequency = new Dictionary<int,int>();  
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            foreach(int i in nums) 
            {
                if (elementsFrequency.ContainsKey(i))
                {
                    elementsFrequency[i]++; 
                }
                else
                {
                    elementsFrequency[i] = 1;
                }
            }
            
            foreach (var keyValue in elementsFrequency)
            {
                priorityQueue.Enqueue(keyValue.Key, -keyValue.Value);
            }

            for (int i = 0; i < k; i++)
                topKElements[i] = priorityQueue.Dequeue();



            return topKElements;
        }
    }
}
