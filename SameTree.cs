using System.Xml.Linq;

namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
		{
            TreeNode p = new TreeNode(1);
            p.right = new TreeNode(2);

            TreeNode q = new TreeNode(1);
            p.left = new TreeNode(2);

            Console.WriteLine(IsSameTree(p, q));

            bool IsSameTree(TreeNode p, TreeNode q)
            {

                if (p == null || q == null) return p == q;

                if (p.val != q.val) return false;

                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
