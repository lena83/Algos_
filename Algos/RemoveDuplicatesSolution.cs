﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class RemoveDuplicatesSolution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
