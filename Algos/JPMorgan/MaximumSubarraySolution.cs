using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class MaximumSubarraySolution
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = Int32.MinValue, cur = 0;

            for (int r = 0; r < nums.Length; r++)
            {
                cur += nums[r];
                max = Math.Max(max, cur);
                //reset to 0 as negative doesn't contribute to max
                if (cur < 0) cur = 0;
            }

            return max;
        }
    }
}
