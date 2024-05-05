namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
        {
            int[] nums = { -10, 8, 6, 7, -2, -3 };

            Console.WriteLine(FindMaxK(nums));
        }

        public static int FindMaxK(int[] nums)
        {
            List<int> listOfKs = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    if (nums.Where(x => x.ToString() == "-" + nums[i].ToString()).Any())
                    {
                        listOfKs.Add(nums[i]);
                    }
                }
                else
                {
                    if(nums.Where(x => "-"+ x.ToString() == nums[i].ToString()).Any())
                    {
                        listOfKs.Add(nums[i]);
                    }
                }
            }    

            if(listOfKs.Count > 0)
            {
                return listOfKs.Max();
            }
            return -1;
        }
    }
}
