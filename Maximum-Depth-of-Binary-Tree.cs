using System.Xml.Linq;

namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
		{
            TreeNode root = new TreeNode(3);
            root.right = new TreeNode(9);
            root.left = new TreeNode(20);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            root.left.right.left = new TreeNode(8);
            root.left.right.right = new TreeNode(9);
            root.right.left.left = new TreeNode(9);
            root.right.left.right = new TreeNode(8);

            Console.WriteLine(MaxDepth(root));

            int MaxDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int left = MaxDepth(root.left);

                int right = MaxDepth(root.right);

                if (left > right)
                {
                    return left + 1;
                }

                return right + 1;
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
