public class Solution {
    public int[] SortArrayByParity(int[] nums) {
       List<int> oddNums = new List<int>();
				List<int> evenNums = new List<int>();
				for (int i = 0; i < nums.Length; i++)
				{
					if (nums[i] % 2 == 0)
					{
						evenNums.Add(nums[i]);
					}
					else
					{
						oddNums.Add(nums[i]);
					}
				}

				evenNums.AddRange(oddNums);

				return evenNums.ToArray();
    }
}
