class Solution(object):
    def subtractProductAndSum(self, n):
        """
        :type n: int
        :rtype: int
        """
        str_n = str(n)
        product = 1
        sum = 0
        for i in str_n:
            x = int(i)
            product *= x
            sum += x

        return product - sum
