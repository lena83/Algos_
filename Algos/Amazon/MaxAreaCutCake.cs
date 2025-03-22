using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class MaxAreaCutCake
    {
        public static int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            int mod = 1_000_000_007;
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);
            int maxH = Math.Max(horizontalCuts[0], h - horizontalCuts[horizontalCuts.Length - 1]);
            for (int i = 1; i < horizontalCuts.Length; i++)
            {
                maxH = Math.Max(maxH, Math.Abs(horizontalCuts[i - 1] - horizontalCuts[i]));
            }
            int maxW = Math.Max(verticalCuts[0], w - verticalCuts[verticalCuts.Length - 1]);
            for (int i = 1; i < verticalCuts.Length; i++)
            {
                maxW = Math.Max(maxW, Math.Abs(verticalCuts[i - 1] - verticalCuts[i]));
            }
            return (int)((long)maxH * maxW % mod);
        }
    }
}
