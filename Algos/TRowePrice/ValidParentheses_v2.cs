using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
    public static class ValidParentheses_v2
    {
        public static bool IsValid(string s)
        {
            if (String.IsNullOrEmpty(s)) return false;
            if (s.Length == 1) return false;
            if (s.Length % 2 != 0) return false;

            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                { '{' , '}'},
                { '[',  ']'},
                { '(', ')' }
            };

            Stack<char> stack = new Stack<char>();  

            foreach(char c in s)
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count > 0 && map[stack.Peek()] == c)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
           
            return stack.Count == 0;
        }
    }
}
