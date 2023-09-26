public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2] {0,0};
				for (int i = 0; i < nums.Length - 1; i++)
				{
					int num1 = nums[i];
					for (int j = i + 1; j < nums.Length; j++)
					{
						int num2 = nums[j];

						if (num1 + num2 == target)
						{
							result[0] = i;
							result[1] = j;
							break;
						}

					}
				}
				return result;
    }
}
