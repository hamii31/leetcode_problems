public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ars = new int[] {0};
        int[] nums_clone = nums;
        ars = nums_clone.Concat(nums).ToArray();

        return ars;
    }
}
