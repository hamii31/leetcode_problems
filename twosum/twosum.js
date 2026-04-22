/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let dict = {}
    for (let i = 0; i < nums.length; i++) {
        complement = target - nums[i]
        if(complement in dict){
            return [dict[complement], i]
        }
        dict[nums[i]] = i
    }
};
