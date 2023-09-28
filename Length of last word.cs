namespace leetcode_problems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "   fly me   to   the moon  ";

			Console.WriteLine(LengthOfLastWord(s));

			int LengthOfLastWord(string s)
			{
				string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				string lastWord = words.Last();
				
				return lastWord.Length;
			}
		}
	}
}
