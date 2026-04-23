int removeCoveredIntervals(int** intervals, int intervalsSize, int* intervalsColSize) {
    int n = intervalsSize;
    int result = n;

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (i != j && intervals[i][0] >= intervals[j][0] && intervals[i][1] <= intervals[j][1]) {
                result--;
                break;
            }
        }
    }
    return result;
}
