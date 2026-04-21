class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        dict = {}
        for i, num in enumerate(nums):
            diff = target - num
            # print(f"Difference {diff} between {target} and {num} for {key}")
            if diff in dict:
                return [dict[diff], i]
            dict[num] = i
