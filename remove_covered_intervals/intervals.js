/**
 * @param {number[][]} intervals
 * @return {number}
 */
var removeCoveredIntervals = function(intervals) {
    let n = intervals.length
    result = n
    for(let i = 0; i < n; i++)
        for(let j = 0; j < n; j++)
            if(i != j && intervals[i][0] >= intervals[j][0] && intervals[j][1] >= intervals[i][1]){
                result -= 1
                break
            }
    return result
};
