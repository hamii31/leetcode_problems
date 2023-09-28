using System.Linq.Expressions;

namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				1,3,5,6
			};

			int target = 0;

			Console.WriteLine(SearchInsert(nums, target));

			int SearchInsert(int[] nums, int target)
			{
				int index = nums.ToList().FindIndex(x => x == target);

				if (index < 0)
				{
					index = nums.ToList().FindIndex(x => x > target);

					if (index < 0)
					{
						bool biggerNumsThanTarget = nums.Any(x => x > target);

						if (biggerNumsThanTarget)
						{
							return 0;
						}

						return nums.Length;
						
					}

					return index;
				}

				return index;
			}
		}
	}
}
