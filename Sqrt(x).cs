using System.Numerics;

namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 4;
			Console.WriteLine(MySqrt(x));

            int MySqrt(int x)
            {
				double sqrt = Math.Floor(Math.Sqrt(x));

				if (sqrt > 0)
				{
					return Convert.ToInt32(sqrt);
				}

				return 0;
            }
        }
	}
}
