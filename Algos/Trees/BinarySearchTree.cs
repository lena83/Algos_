using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Trees
{
    public class BinarySearchTree
    {
        public bool IsValidBinarySearchTreeHelper(TreeNode root, int min, int max)
        {

            if (root == null) return true;

            int val = root.Data;

            var isValidLeft = IsValidBinarySearchTreeHelper(root.Left, min, val);

            var isValidRight = IsValidBinarySearchTreeHelper(root.Right, val, max);

            if (val > min && val < max && isValidLeft && isValidRight) return true;
            return false;


        }

        public bool IsValidBinaryTreeSearch(TreeNode root)
        {
            int min = Int32.MinValue;
            int max = Int32.MaxValue;

            return IsValidBinarySearchTreeHelper(root, min, max);

        }
    }
}
