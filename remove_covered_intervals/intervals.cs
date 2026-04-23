public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        int n = intervals.Length;
        int result = n;

        for(int i = 0; i < n; i++)
            for(int j = 0; j < n; j++){
                if(i != j && intervals[i][0] >= intervals[j][0]
                && intervals[j][1] >= intervals[i][1]){
                    result -= 1;
                    break;
                }
            }
        return result;
    }
}
