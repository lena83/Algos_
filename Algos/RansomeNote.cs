using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class RansomeNote
    {

        public bool IsRansomeNote(char[] magazine, string note)
        {
            bool result = false;
            Dictionary<char, int> magChars = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (magChars.ContainsKey(c))
                {
                    magChars[c]++;
                }
                else
                {
                    magChars.Add(c, 1);
                }
            }

            foreach (char n in note)
            {
                if (magChars.ContainsKey(n))
                {
                    result = true;
                    magChars[n]--;

                    if (magChars[n] == 0) magChars.Remove(n);
                }
                else
                {
                    result = false;
                    break;
                }

            }

            return result;
        }
    }
}
