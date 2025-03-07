using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algos.JPMorgan
{
    public static class MaximumUnitsSolution
    {
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int max = 0;
            int index = 0;
            Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));

            while (truckSize > 0 && index <= boxTypes.Length - 1)
            {
                
                if (truckSize - boxTypes[index][0] > 0)
                {
                    truckSize -= boxTypes[index][0];
                    max += boxTypes[index][1] * boxTypes[index][0];
                }
                else
                {
                    max += boxTypes[index][1] * truckSize;
                    truckSize = 0;
                    break;
                }
                
                if (truckSize > 0) index++;
                else
                {
                    break;
                }

            }
            return max;
        }
    }
}
