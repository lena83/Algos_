using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class MaximumUnits_
    {
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        { 
            var maxUnits = 0;
            int index = 0;
            Array.Sort(boxTypes, (a,b) => b[1].CompareTo(a[1]));

            while (truckSize > 0 && index < boxTypes.Length)
            {
                var units = boxTypes[index][0] * boxTypes[index][1];
                if (truckSize - boxTypes[index][0] >= 0)
                {
                    maxUnits += units;
                    truckSize -= boxTypes[index][0];
                }
                else
                {
                    maxUnits += truckSize * boxTypes[index][1];
                    truckSize = 0;
                }

                index++;
                
            }
            return maxUnits;
        }
    }
}
