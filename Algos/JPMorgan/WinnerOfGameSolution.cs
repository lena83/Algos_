using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.JPMorgan
{
    public static class WinnerOfGameSolution
    {
        public static bool WinnerOfGame(string colors)
        {
            int countA = 0;
            int countB = 0;

            for (int i = 1; i < colors.Length - 1; i++)
            {
                if (i + 1 > colors.Length - 1) break;
                if (colors[i] == 'A' && colors[i-1] == 'A'  && colors[i+1] == 'A')
                {
                    countA++;
                }
                if (colors[i] == 'B' && colors[i - 1] == 'B' && colors[i + 1] == 'B')
                {
                    countB++;
                }

            }
            return countA > countB;
        }
    }
}
