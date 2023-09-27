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
				int index = 0;

				while (true)
				{
					if (index < firstString.Length)
					{
						prefix += firstString[index];
					}
					else if (index >= firstString.Length)
					{
						if (index <= 1)
						{
							prefix = prefix.Remove(prefix.Length);
							break;
						}
						else
						{
							prefix = prefix.Remove(prefix.Length);
							break;
						}
					}

					bool result = strs.All(x => x.StartsWith(prefix));

					if (!result)
					{
						prefix = prefix.Remove(prefix.Length - 1);
						break;
					}
					else
					{
						index++;
					}

				}
				return prefix;
			}
		}
		
	}
}
