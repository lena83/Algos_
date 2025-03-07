using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class HappyNumberSolution
    {
        public static bool HappyNumber(int n)
        {
            var nums = GetListOfDigits(n);
           
            while (nums.Count > 1 || (nums.Count == 1 && (nums[0] == 1 || nums[0] == 7)))
            {
                var sum = 0;
                foreach (var x in nums)
                {
                    sum += x * x;
                }

                if (sum == 1) return true;
                else
                {
                    nums = GetListOfDigits(sum);
                }
            }

            return false;
        }

        public static List<int> GetListOfDigits(int n)
        {
            List<int> listOfInts = [];
            while (n > 0)
            {
                Console.WriteLine(n % 10);
                listOfInts.Add(n % 10);
                Console.WriteLine(n);
                n /= 10;
                Console.WriteLine(n);
            }
            return listOfInts;
        }
    }
}
