class Solution(object):
    def removeCoveredIntervals(self, intervals):
        """
        :type intervals: List[List[int]]
        :rtype: int
        """
        n = len(intervals)
        result = n
        for i in range(n):
            for j in range(n):
                  if i != j and intervals[i][0] >= intervals[j][0] and intervals[j][1] >= intervals[i][1]:
                        result -= 1
                        break
        return result
