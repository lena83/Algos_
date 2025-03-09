using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class SlowestKeySolution
    {
        public static char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            var index = 0;
            var maxReleaseTime = releaseTimes[index];
            for (var i = 1; i < releaseTimes.Length; i++)
            {
                var itemReleaseTime = releaseTimes[i] - releaseTimes[i - 1];
                if (itemReleaseTime == maxReleaseTime)
                {
                    if (keysPressed[i] > keysPressed[index])
                    {
                        index = i;
                    }
                }
                else if (itemReleaseTime > maxReleaseTime)
                {
                    index = i;
                }
                maxReleaseTime = Math.Max(itemReleaseTime, maxReleaseTime);



            }
            return keysPressed[index];
        }
    }
}
