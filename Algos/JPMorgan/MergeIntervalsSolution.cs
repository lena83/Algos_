using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class MergeIntervalsSolution
    {
        public static int[][] Merge(int[][] intervals)
        {
            var mergedIntervals = new List<int[]>();

            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            if (intervals.Length ==1 ) { return intervals; }

            var prevInterval = intervals[0];
            mergedIntervals.Add(prevInterval);
            int index = 0;
            for (int i = 1;i< intervals.Length; i++)
            {

                if (intervals[i][0] <= prevInterval[1])
                {
                    var startInterval = prevInterval[0];
                    var endInterval = intervals[i][1];

                    if (intervals[i][1] < prevInterval[1])
                    {
                        endInterval = prevInterval[1];
                    }
                    var mergedInterval = new[] { startInterval, endInterval };
                   
                    mergedIntervals[index] = mergedInterval;
                    prevInterval = mergedInterval;
                }
                else
                {
                    mergedIntervals.Add(intervals[i]);
                    index++;
                    prevInterval = intervals[i];
                }
            }
            return mergedIntervals.ToArray();
        }
    }
}
