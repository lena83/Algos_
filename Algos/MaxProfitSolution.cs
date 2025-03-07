using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class MaxProfitSolution
    {
        public static int MaxProfit(int[] prices)
        {
         
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i])
                    {
                        maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
                    }
                }
            }
            
            return maxProfit;
        }
    }
}
