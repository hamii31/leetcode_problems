class Solution(object):
    def numJewelsInStones(self, jewels, stones):
        """
        :type jewels: str
        :type stones: str
        :rtype: int
        """
        Jcount = 0
        for i in jewels:
            Jcount += stones.count(i)

        return Jcount
