namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string haystack = "sadbutsad";
			string needle = "sad";

			Console.WriteLine(StrStr(haystack, needle));

			int StrStr(string haystack, string needle)
			{
				if (!haystack.Contains(needle))
				{
					return -1;
				}

				return haystack.IndexOf(needle);
			}
		}
	}
}
