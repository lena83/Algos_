using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class MaxAverageRatio
    {
        public static double MaxAverageRatioProblem(int[][] classes, int extraStudents)
        {

            var maxHeap = new PriorityQueue<(double diff, int pass, int total), double>();

            foreach (var cls in classes)
            {
                int pass = cls[0], total = cls[1];
                double diff = (double)(pass + 1) / (total + 1) - (double)pass / total;
                maxHeap.Enqueue((diff, pass, total), -diff);
            }

            while (extraStudents > 0)
            {
                var (diff, pass, total) = maxHeap.Dequeue();
                pass++;
                total++;
                diff = (double)(pass + 1) / (total + 1) - (double)pass / total;
                maxHeap.Enqueue((diff, pass, total), -diff);
                extraStudents--;
            }


            double sum = 0;
            while (maxHeap.Count > 0)
            {
                var (_, pass, total) = maxHeap.Dequeue();
                sum += (double)pass / total;
            }
            return sum / classes.Length;

        }
    }
}
