using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDepthBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private Int32 MinDepth(TreeNode root)
        {
        if (root == null)
        {
          return 0;
        }
            return FindMinDepth(root);
        }
        private static Int32 FindMinDepth(TreeNode root)
        {
            if (root == null)
            {
                return Int32.MaxValue;
            }
            else if (root.left == null && root.right == null)
            {
                return 1;
            }
            else return Math.Min(FindMinDepth(root.left), FindMinDepth(root.right))+1;
        }
    }
}
