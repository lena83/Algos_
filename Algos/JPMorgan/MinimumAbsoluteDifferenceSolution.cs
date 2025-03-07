using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class MinimumAbsoluteDifferenceSolution
    {
       
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            int min = Int32.MaxValue;
            Array.Sort(arr);
            var result = new List<IList<int>> { };
            for (int r = 0; r < arr.Length -1; r++)
            {
                var diff = arr[r+1] - arr[r];

                int prevMin = Math.Abs(min);

                min = Math.Min(Math.Abs(min), diff);
                
                if (prevMin > min )
                {
                    result.Clear();
                }
                if (prevMin == min && diff > min) { continue; }

                result.Add(new[] { arr[r], arr[r + 1] });
            }

            return result;
        }
    }
}
