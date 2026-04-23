public class Solution {
    public int SubtractProductAndSum(int n) {
        string str = n.ToString();
        int product = 1;
        int sum = 0;
        for(int i = 0; i < str.Length; i++){
            int x = str[i] - '0';
            product *= x;
            sum += x;
        }

        return product - sum;
    }
}
