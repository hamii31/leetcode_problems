using System.Numerics;

namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] digits = new int[]
			{
				7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6
			};

			Console.WriteLine(string.Join(", ", PlusOne(digits)));

			int[] PlusOne(int[] digits)
			{
				string text = string.Join("", digits);

				BigInteger digit = BigInteger.Parse(text) + 1;

				int[] result = digit.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

				return result;
			}
		}
	}
}
