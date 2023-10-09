using System.Xml.Linq;

namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
		{
            TreeNode root = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(4);
            root.left.right.left = new TreeNode(8);
            root.left.right.right = new TreeNode(9);
            root.right.left.left = new TreeNode(9);
            root.right.left.right = new TreeNode(8);

            Console.WriteLine(IsSymmetric(root));

            bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }
                return IsMirrored(root.left, root.right);
            }

            bool IsMirrored(TreeNode root1, TreeNode root2)
            {
                if (root1 == null && root2 == null)
                {
                    return true;
                }
                else if (root1 == null || root2 == null)
                {
                    return false;
                }
                else
                {
                    return root1.val == root2.val && IsMirrored(root1.left, root2.right) 
                                                  && IsMirrored(root1.right, root2.left);
                }
            }
           
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
         }
    }
}
