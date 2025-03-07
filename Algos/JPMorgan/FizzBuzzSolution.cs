using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class FizzBuzzSolution
    {
        public static IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();
            for (int i = 1; i <= n; i++) 
            {

                if (i%5 == 0 && i % 3 == 0) result.Add("FizzBuzz");
                else if (i % 5 != 0 && i % 3 == 0) result.Add("Fizz");
                else if (i % 5 == 0 && i % 3 != 0) result.Add("Buzz");
                else result.Add(i.ToString());
            }
            return result;  
        }

        public static IList<string> FizzBuzz_v2(int n)
        {
            var list = new List<string>(n);

            for (int i = 1; i <= n; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString()
                };

                list.Add(item);
            }

            return list;
        }
    }
}
