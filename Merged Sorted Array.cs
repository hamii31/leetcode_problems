internal class Program
{

    static void Main(string[] args)
    {
        int[] nums1 = {1,2,3,0,0,0};
        int[] nums2 = {2,5,6};
        int m = 3;
        int n = 3;

        Merge(nums1, m, nums2, n);
    }
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // Remove zeros, merge two arrays and sort
        nums1 = nums1.Where(x => x != 0)
                          .Concat(nums2.Where(x => x != 0))
                          .OrderBy(x => x)
                          .ToArray();

        return nums1;
    }

}
