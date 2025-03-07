using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Citadel
{
    public static class DeleteAndEarnSolution
    {
        public static int DeleteAndEarn(int[] nums)
        {
            int maxEarnings = 0;
            Dictionary<int,int> freq = new Dictionary<int,int>();
            var prev = 0;
            var next = 0;
            foreach (var num in nums)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                   freq.Add(num, 1);    
                }
            }

            foreach (var keyValue in freq)
            {
                var curr = keyValue.Key;
                prev = keyValue.Key - 1;
                next = keyValue.Key + 1;
                var sum = keyValue.Key * keyValue.Value + freq.Where(x => x.Key != curr && x.Key != prev && x.Key != next).Sum(x => x.Key);
                maxEarnings = Math.Max(maxEarnings, sum);
            }

            return maxEarnings;
        }
    }
}
