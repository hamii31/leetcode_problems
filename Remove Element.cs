namespace leetcode_problems
{
	internal class Program
	{

	    static void Main(string[] args)
	    {
	        int[] nums = {0,1,2,2,3,0,4,2};
	        int val = 2;
	        Console.WriteLine(RemoveElement(nums, val));
	    }
	    public static int RemoveElement(int[] nums, int val)
	    {
	
	        nums = nums.Where(x => x != val).ToArray();
	
	        return nums.Length;
	    }
	
	}
}
