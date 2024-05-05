namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
        {
            //Ugly Number
            int n = 6;

            Console.WriteLine(IsUgly(n));
        }
        public static bool IsUgly(int n)
        {

            // If n is 1 or the recursive n is 1, the number is Ugly
            if (n == 1)
            {
                return true;
            }
            if (n <= 0)
            {
                return false;
            }

            if (n % 2 == 0)
            {
                // Checks if 2 is a prime factor for n
                return IsUgly(n / 2);
            }
            if (n % 3 == 0)
            {
                // Checks if 3 is a prime factor for n
                return IsUgly(n / 3);
            }
            if (n % 5 == 0)
            {
                // Checks if 5 is a prime factor for n
                return IsUgly(n / 5);
            }

            return false;

        }

    }
}
