using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class CompressString
    {
        public static int Compress(char[] chars)
        {

            if (chars.Length == 0) return 0;

            StringBuilder compressed = new StringBuilder();

            if (chars.Length == 1) { compressed.Append(chars[0]); }

            var current = chars[0];
            int counter = 1;

                  
            for (int i = 1; i<= chars.Length - 1; i++)
            {
                if (current == chars[i])
                {
                    counter++;
                }
                if (current == chars[i] && i == chars.Length - 1)
                {
                    compressed.Append(current);
                    if (counter > 1) compressed.Append(counter);
                }
                if (current != chars[i])
                {
                    if (counter > 1)
                    {
                        compressed.Append(current);
                        compressed.Append(counter);
                    }
                    else
                    {
                        compressed.Append(current);
                    }
                    counter = 1;
                }
                if (current != chars[i] && i == chars.Length - 1)
                {
                    if (counter > 1)
                    {
                        compressed.Append(counter);
                        compressed.Append(chars[i]);
                    }
                    else
                    {
                        compressed.Append(chars[i]);
                    }
                    counter = 1;
                }
                current = chars[i];
            }

            Array.Clear(chars);
            var arr = compressed.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                chars[i]= arr[i];
            }
            
            return arr.Length;
        }

        public static int Compress_v2(char[] chars)
        {
            if (chars.Length == 0)
                return 0;

            int writeIndex = 0;
            char currentChar = chars[0];
            int count = 1;

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    chars[writeIndex++] = currentChar;
                    if (count > 1)
                    {
                        foreach (char digit in count.ToString())
                        {
                            chars[writeIndex++] = digit;
                        }
                    }

                    currentChar = chars[i];
                    count = 1;
                }
            }

            chars[writeIndex++] = currentChar;
            if (count > 1)
            {
                foreach (char digit in count.ToString())
                {
                    chars[writeIndex++] = digit;
                }
            }

            return writeIndex;
        }
    }
}
