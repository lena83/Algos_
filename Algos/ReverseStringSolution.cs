using System.Text;

namespace Algos
{
    public static class ReverseStringSolution
    {
        public static string ReverseString(string a)
        {
            if (String.IsNullOrEmpty(a)) return a;

            if (a.Length == 1) return a;

            StringBuilder b = new StringBuilder();
            for (int i = a.Length-1; i>= 0;  i--)
            {
                b.Append(a[i]);
            }
            return b.ToString();
        }

        public static string ReverseString_v2(string a)
        {
            if (String.IsNullOrEmpty(a)) return a;

            if (a.Length == 1) return a;

            Stack<char> stack = new Stack<char>();

            foreach(var c in a)
            {
                stack.Push(c);
            }

            return String.Join("", stack);
        }

        public static string ReverseString_v3(string a)
        {
            if (String.IsNullOrEmpty(a)) return a;

            if (a.Length == 1) return a;
            var charArray = a.ToCharArray();
            int left = 0;
            int right = a.Length - 1;
            char temp;
            while (left < right) 
            {
                temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }

            return new string(charArray);
        }
    }
}
