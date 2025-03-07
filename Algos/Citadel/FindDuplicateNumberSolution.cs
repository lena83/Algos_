using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Citadel
{
    public static  class FindDuplicateNumberSolution
    {
        public static int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    result =  nums[i];
                    break;
                }
            }
            return result;
        }

        public static int FindDuplicate_v2(int[] nums)
        {
            Dictionary<int,int> frequency = new Dictionary<int,int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               if (!frequency.ContainsKey(nums[i]))
                {
                    frequency.Add(nums[i], 1);
                }
               else
                {
                    frequency[nums[i]]++;
                    result = nums[i];
                }
            }



            return result;
        }
    }
}
