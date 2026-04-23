/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* getConcatenation(int* nums, int numsSize, int* returnSize) {
    int* ars = (int*)malloc(sizeof(int) * numsSize * 2);
	for (int i = 0; i < numsSize; i++) {
		ars[i] = nums[i];
	}
	for (int i = 0; i < numsSize; i++) {
		ars[i + numsSize] = nums[i];
	}
	*returnSize = numsSize * 2;
	return ars;
}
