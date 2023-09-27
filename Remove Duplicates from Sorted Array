namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				0,0,1,1,1,2,2,3,3,4
			};

			Console.WriteLine(RemoveDuplicates(nums));

			int RemoveDuplicates(int[] nums)
			{
				nums.OrderBy(x => x);

				return nums.Distinct().Count();
			}
		}
	}
}
