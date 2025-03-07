using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public static class StringCompression_v2
    {

        public static int Compress_v2(char[] chars)
        {
            if (chars.Length == 0) return 0;
            if (chars.Length == 1) return 1;
            int writeIndex = 0;
            int i = 0;
            while( i < chars.Length)
            {
                int j = i;
                while (j < chars.Length && chars[i] == chars[j])
                {
                    j++;
                }
                chars[writeIndex++] = chars[i];
                int counter = j - i;
                if (counter > 1 && counter < 10)
                {
                    chars[writeIndex++] = (char)(counter + '0');
                }
                if (counter > 1 && counter >= 10)
                {
                    var nums = counter.ToString().ToCharArray();
                    for (int n = 0; n < nums.Length; n++)
                    {
                        chars[writeIndex++] = nums[n];
                    }
                }
                i = j;
                
            }
            return writeIndex;
        }

        public static int Compress_v3(char[] chars)
        {
            if (chars.Length == 0) return 0;
            if (chars.Length == 1) return 1;

            int writeIndex = 0;

            int i = 0;

            while ( i < chars.Length)
            {
                int j = i;
                while (j < chars.Length && chars[i] == chars[j])
                {
                    j++;
                }
                var counter = j - i;
                chars[writeIndex++] = chars[i];
                 if (counter > 1 && counter < 10)
                {
                    var num = (char)(counter + '0');
                    chars[writeIndex++] = num;
                }
                 if (counter >= 10)
                {
                    var nums = counter.ToString().ToCharArray();
                    for (int n = 0; n < nums.Length; n++)
                    {
                        chars[writeIndex++] = nums[n];
                    }
                }
                i = j;
                
            }

            return writeIndex;
        }

            public static int Compress(char[] chars)
        {
            if (chars.Length == 0) return 0;
            if (chars.Length == 1) return 1;

            var prev = chars[0];

            var counter = 1;
            var writeIndex = 0;

            char[] charsCopy = new char[chars.Length];
            charsCopy[0] = prev;

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == prev)
                {
                    counter++;
                }
                if (chars[i] != prev)
                {
                    if (counter > 1 && counter < 10)
                    {
                        charsCopy[++writeIndex] = (char)(counter + '0'); 
                    }
                    else if (counter > 10)
                    {
                        var nums = counter.ToString().ToCharArray();
                        for (int j = 0; j < nums.Length; j++)
                        {
                            charsCopy[++writeIndex] = nums[j];
                        }
                    }
                    charsCopy[++writeIndex] = chars[i];
                    counter = 1;
                }
                prev = chars[i];
            }

            if (counter > 1 && counter < 10)
            {
               
                charsCopy[++writeIndex] = (char)(counter + '0'); 
               
            }
            else if (counter >= 10)
            {
                var nums = counter.ToString().ToCharArray();

                for (int j = 0; j < nums.Length; j++)
                {
                    charsCopy[++writeIndex] = nums[j];
                }
            }
            Array.Clear(chars);
            Array.Copy(charsCopy, chars, charsCopy.Length);
            return writeIndex + 1;
        }
    }
}
