using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class DecodeStringSolution
    {
        public static string DecodeString(string s)
        {
            string result = String.Empty;

            int i = 0;
            while (i < s.Length)
            {
                if (Char.IsDigit(s[i]))
                {
                    var currentStr = new StringBuilder();
                    var currentDigit = s[i] - '0';
                    i = i + 2;
                    while (Char.IsLetter(s[i]))
                    {
                        currentStr.Append(s[i]);
                        i++;
                    }

                    result += string.Concat(Enumerable.Repeat(currentStr.ToString(), currentDigit));

                }
                else if (Char.IsLetter(s[i]))
                {
                    result += s[i];
                }
                i++;
            }

            return result;
        }


        public static string DecodeString_v2(string s)
        {
            var repeat = 0;
            var sb = new StringBuilder(s.Length);
            var st = new Stack<(int start, int repeat)>();

            foreach (var c in s)
            {
                if (c == '[')
                {
                    st.Push((sb.Length, repeat));
                    repeat = 0;
                }
                else if (c == ']')
                {
                    var (start, times) = st.Pop();

                    for (var length = sb.Length - start; times > 1; times--)
                    {
                        sb.Append(sb, start, length);
                    }
                }
                else if (Char.IsDigit(c))
                {
                    repeat = 10 * repeat + (c - '0');
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static string DecodeString_v3(string s)
        {
            Stack<char> charsStack = new Stack<char>();
            var sb = new StringBuilder(s.Length);

            foreach (char c in s)
            {
                if (c != ']')
                {
                    charsStack.Push(c);
                }
                if (charsStack.Count > 0 && c == ']')
                {
                    var substring = String.Empty;
                    var repeat = 0;
                    while (charsStack.Peek() != '[')
                    {
                        if (Char.IsLetter(charsStack.Peek()))
                        {
                            substring = charsStack.Pop() + substring;
                        }
                    }
                    charsStack.Pop();
                    string digitStr = String.Empty;
                    while (charsStack.Count > 0 && Char.IsDigit(charsStack.Peek()))
                    {
                        digitStr += charsStack.Pop();
                    }
                    var digit = Int32.Parse(digitStr);
                    var str = string.Concat(Enumerable.Repeat(substring, digit));

                    foreach (char ch in str)
                    {
                        charsStack.Push(ch);
                    }
                }
            }

            return String.Join("", charsStack.Reverse());

        }

        public static int NumDecodings(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s[0] == '0')
            {
                return 0;
            }

            int oneAgo = 1;
            int twoAgo = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int cur = s[i] == '0' ? 0 : oneAgo;

                if (i < s.Length - 1 && (s[i] == '1' || (s[i] == '2' && s[i + 1] < '7')))
                {
                    cur += twoAgo;
                }
                twoAgo = oneAgo;
                oneAgo = cur;
            }

            return oneAgo;
        }

        public static int NumDecodings_v2(string s)
        {
            var dp = new int[s.Length + 1];
            dp[s.Length] = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    dp[i] = 0;
                }
                else
                {
                    dp[i] = dp[i + 1];
                }

                if (i + 1 < s.Length)
                {
                    if (s[i] == '1' && ((int)Char.GetNumericValue(s[i + 1]) >= 0 || (int)Char.GetNumericValue(s[i + 1]) <= 9))
                    {
                        dp[i] = dp[i] + dp[i + 2];
                    }
                    if (s[i] == '2' && ((int)Char.GetNumericValue(s[i + 1]) >= 0 && (int)Char.GetNumericValue(s[i + 1]) <= 6))
                    {
                        dp[i] = dp[i] + dp[i + 2];
                    }
                }
                
            }
            return dp[0];
        }
    }
}
