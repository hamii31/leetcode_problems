using System.Numerics;
using System.Xml.Linq;

namespace leetcode_problems
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 11, 81, 94, 43, 3};

            Console.WriteLine(SumSubarrayMins(arr));
        }
        public static int SumSubarrayMins(int[] arr)
        {
            //Given an array of integers arr, find the sum of min(b),
            //where b ranges over every (contiguous) subarray of arr.
            //Since the answer may be large, return the answer modulo 109 + 7.

            int maxLength = 0;
            List<int> miniNums = new List<int>();

            for(int i = 1; i <= arr.Length; i++)
            {
                for (int n = 0; n < arr.Length; n++)
                {
                    var newArray = arr.Skip(n).Take(i).ToArray();

                    if(n == 0)
                    {
                        maxLength = newArray.Length;
                    }
                    if(newArray.Length == maxLength)
                    {
                        miniNums.Add(newArray.Min());
                    }
                }
            }

            return (int)(miniNums.Sum() % (Math.Pow(10, 9) + 7));
        }
    }
}
