using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class MinStepsAnagramSolution
    {
        public static int MinSteps(string s, string t)
        {
            Dictionary<char,int> freqT = new Dictionary<char,int>();
            int countSteps = 0;
            foreach (var c in t)
            {
                if (freqT.ContainsKey(c))
                {
                    freqT[c]++;
                }
                else
                {
                    freqT.Add(c, 1);
                }
            }

            foreach(var c1 in s)
            {
                if (!freqT.ContainsKey(c1)) { countSteps++;}
                else
                {
                    freqT[c1]--;
                    if (freqT[c1] == 0)
                    {
                        freqT.Remove(c1);
                    }
                }
            }
            return countSteps;
        }
    }
}
