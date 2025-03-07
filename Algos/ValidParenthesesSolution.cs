using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            bool isValid = false;
            if (String.IsNullOrEmpty(s)) isValid = false;


            Stack<char> openParenthes = new Stack<char>();

            if (s[0] == ']' || s[0] == '}' || s[0] == ')') { return false; }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[' || s[i] == '{' || s[i] == '(')
                {
                    openParenthes.Push(s[i]);
                }

                if (s[i] == ']' && openParenthes.Count > 0 && openParenthes.Peek() == '[')
                {
                    openParenthes.Pop();
                }
                else if (s[i] == ']' && openParenthes.Count > 0 && (openParenthes.Peek() == '{' || openParenthes.Peek() == '('))
                {
                    return false;
                }
                else if (s[i] == '}' && openParenthes.Count > 0 && openParenthes.Peek() == '{')
                {
                    openParenthes.Pop();
                }
                else if (s[i] == '}' && openParenthes.Count > 0 && (openParenthes.Peek() == '[' || openParenthes.Peek() == '('))
                {
                    return false;
                }
                else if (s[i] == ')' && openParenthes.Count > 0 && openParenthes.Peek() == '(')
                {
                    openParenthes.Pop();
                }
                else if ((s[i] == ']' || s[i] == '}' || s[i] == ')') && openParenthes.Count == 0) { return false; }
                else if (s[i] == ')' && openParenthes.Count > 0 && (openParenthes.Peek() == '[' || openParenthes.Peek() == '{'))
                {
                    return false;
                }
                if (openParenthes.Count == 0 && i == s.Length - 1) isValid = true;
            }

            if (s.Length == 1) isValid = false;

            return isValid;
        }

        public static  bool IsValid_2(string s)
        {

                if (string.IsNullOrEmpty(s))
                {
                    return true; 
                }

                Dictionary<char, char> parenthesesMapping = new()
                {
                    { '(', ')' },
                    { '{', '}' },
                    { '[', ']' }
                };

                Stack<char> openParentheses = new();

                foreach (char c in s)
                {
                    if (parenthesesMapping.ContainsKey(c))
                    {
                        openParentheses.Push(c);
                    }
                    else if (parenthesesMapping.ContainsValue(c))
                    {
                        if (openParentheses.Count == 0 || parenthesesMapping[openParentheses.Pop()] != c)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false; 
                    }
                }

                return openParentheses.Count == 0;
        }
    }
}
