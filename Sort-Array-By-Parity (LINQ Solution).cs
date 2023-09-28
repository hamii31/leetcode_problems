public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        nums = nums.OrderByDescending(x => x % 2 == 0).ToArray();

				return nums;
    }
}
