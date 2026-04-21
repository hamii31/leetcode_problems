class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        result = []
        index = 1
        for i in nums:
     
            for j in nums[index:]:
                if i+j == target:
                    if i == j:
                        result = [n for n, x in enumerate(nums) if x == i]
                    else:
                        result.append(nums.index(i))
                        result.append(nums.index(j))
                    return result
            index += 1
