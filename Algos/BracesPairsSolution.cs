using System.Text;

namespace Algos
{
    public static class BracesPairsSolution
    {
        private const char opening = '[';
        private const char closing = ']';
        public static bool IsStringWithBracesValid(string a)
        {
            if (String.IsNullOrEmpty(a)) return false;

            if (a.Length == 1) return false;

            Dictionary<char, int> bracesPairsOccurence = [];
            
            foreach (char c in a) 
            { 
                if (c == opening)
                {
                   if (bracesPairsOccurence.TryGetValue(c, out int value)) bracesPairsOccurence[c]++;
                   else bracesPairsOccurence[c] = value;
                }
                if (c == closing)
                {
                    if (bracesPairsOccurence.TryGetValue(c, out int value)) bracesPairsOccurence[c]++;

                    else
                    {
                        if (!bracesPairsOccurence.ContainsKey(opening)) return false;

                        bracesPairsOccurence[c] = value;
                    }
                    
                }
            }

            return bracesPairsOccurence.Values.All(value => value == bracesPairsOccurence.Values.First()); ;
        }
    }
}
