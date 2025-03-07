using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class ConnectSticksSolution
    {
        public static int ConnectSticks(int[] sticks)
        {
            var heap = new PriorityQueue<int, int>();

            for (int i = 0; i < sticks.Length; i++)
            {
                heap.Enqueue(sticks[i], sticks[i]);
            }

            var sum = 0;
            while (heap.Count > 1)
            {
                var el1 = heap.Dequeue();
                var el2 = heap.Dequeue();

                sum += el1 + el2;
                heap.Enqueue(el1 + el2, el1 + el2);
            }

            return sum;
        }
    }
}
