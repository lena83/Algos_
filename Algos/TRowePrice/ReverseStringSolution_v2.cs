using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.TRowePrice
{
   public static class ReverseStringSolution_v2
    {
        public static string ReverseString (string a)
        {
            int left = 0;
            int right = a.Length - 1;
            char temp;
            var arr = a.ToCharArray ();
            while (left < right)
            {
                temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
                left++;
                right--;
            }

            return new string(arr);
        }

        public static string ReverseStringStack(string a)
        {
            Stack<char> chars = new Stack<char>();  
            StringBuilder sb = new StringBuilder(); 
            foreach(char c in a)
            {
                chars.Push(c);
            }  

            while (chars.Count > 0) 
            {
                sb.Append(chars.Pop());
            }
            return sb.ToString();
        }
    }
}
