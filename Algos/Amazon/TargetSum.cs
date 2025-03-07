using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Amazon
{
    public static class TargetSum
    {
        static IList<IList<int>> result = new List<IList<int>>();
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            DFS(candidates, target, new List<int>(), 0);
            return result;
        }
        private static void DFS(int[] candidates, int target, IList<int> currentList, int index)
        {
            if (index >= candidates.Length || target < 0)
            {
                return;
            }
            if (target == 0)
            {
                int[] curr = new int[currentList.Count];
                currentList.CopyTo(curr, 0);
                result.Add(curr);
                return;
            }

            //Include the value
            currentList.Add(candidates[index]);
            DFS(candidates, target - candidates[index], currentList, index);
            currentList.RemoveAt(currentList.Count - 1);
            DFS(candidates, target, currentList, index + 1);
        }
    }
}
