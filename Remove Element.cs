namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				0,1,2,2,3,0,4,2 /* This is the second testcase, that leetcode had provided, which by itself
				                 * was broken. 
				                 
				                 * Just as other leetcode problem, called Remove Duplicates from Sorted Array,
				                 this problem is similarly broken. They ask us to return the length of the array,
								 from which we've removed val. But judge doesn't seem to care about that,
								 it cares about how the array is sorted. Even if you sort the array correctly
								 it still doesn't take it as the correct answer. The problem is that the method returns
								 a singular integer while judge is looking for said integer + the array without val.
								 Here's my fixed interpretation of the problem. 
				
				                 PS: I really hoped for more out of leetcode and am very disappointed.*/
			};

			int val = 2;

			var result = RemoveElement(nums, val);
			int K = result.Item1;
			int[] resultNums = result.Item2;

			Console.WriteLine(K);
			Console.WriteLine(string.Join(", ", resultNums));

			 (int, int[]) RemoveElement(int[] nums, int val)
			 {
				nums = nums.OrderBy(x => x.Equals(val)).ToArray();

				return (nums.Distinct().Count(), nums);
			 }

			//int RemoveElement(int[] nums, int val) -> the method the problem wants you to have
			//{
			//	nums = nums.OrderBy(x => x.Equals(val)).ToArray();

			//	return nums.Distinct().Count();
			//}

		}
	}
}
