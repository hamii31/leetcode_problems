namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strs = new string[]
			{
				"ab", "abcc"
			};

			Console.WriteLine(LongestCommonPrefix(strs));

			string LongestCommonPrefix(string[] strs)
			{
				if (strs.Length < 1 || strs.Contains(""))
				{
					return string.Empty;
				}
				if (strs.Length == 1 || strs.GroupBy(x => x).Any(g => g.Count() == strs.Length))
				{
					return strs[0];
				}

				string firstString = strs[0];
				string prefix = string.Empty;
				int index = firstString.Length;

				while (true)
				{
					prefix = firstString.Substring(0, index);
					bool allStartWithPrefix = strs.All(x => x.StartsWith(prefix));

					if (allStartWithPrefix)
					{
						return prefix;
					}
					else
					{
						index--;
					}
				}
			}
		}
		
	}
}
