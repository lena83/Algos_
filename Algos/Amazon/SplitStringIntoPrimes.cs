using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algos.Amazon
{
    public static class SplitStringIntoPrimes
    {
        public static int SplitPrimes(string inputStr)
        {
            List<List<int>> primeCombinations = new List<List<int>>();
            
            var i = 0;
            var j = 0;
            int currentNum = 0;
            int outerLoopCurrentNum = 0;
            while (j < inputStr.Length)
            {
                var primeCombination = new List<int>();
                i = j;
                currentNum = outerLoopCurrentNum;
                while (i < inputStr.Length)
                { 
                    var num = currentNum + inputStr[i] - '0';
                    var isPrime = IsPrime(num);
                    if (isPrime)
                    {
                        primeCombination.Add(num);
                        currentNum = 0;
                    }
                    else
                    {
                        currentNum += num * 10;
                    }
                    i++;

                }
                primeCombinations.Add(primeCombination);
                if (outerLoopCurrentNum == 0) outerLoopCurrentNum += (inputStr[j] - '0') * 10;
                else
                {
                    outerLoopCurrentNum += inputStr[j] - '0';
                    outerLoopCurrentNum = outerLoopCurrentNum * 10;
                }
                

                j++;
                
            }
          
            
            return primeCombinations.Count;
        }

        public static bool IsPrime(int num)
        {
            if (num == 2 || num == 1) return false;
            
            if (num%2 == 0 || num % 3 == 0) return false;

            return true;

        }

    }
}
