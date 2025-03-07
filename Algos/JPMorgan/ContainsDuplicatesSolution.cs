using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class ContainsDuplicatesSolution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (int i in nums)
            {
                if (result.Contains(i)) { return true; }
                else result.Add(i);
            }
            return false;
        }
        public static bool ContainsDuplicate_2(int[] nums)
        {
            Dictionary<int,int> result = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (result.ContainsKey(i)) 
                { 
                    result[i]++;
                    if (result[i]>1) return true; 
                }
                else result.Add(i, 1);
            }
            return false;
        }
    }
}
