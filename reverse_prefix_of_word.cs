namespace leetcode_problems
{
    internal class Program
	{
        static void Main(string[] args)
        {
            string word = "abcdefg";
            char ch = 'd';

            Console.WriteLine(ReversePrefix(word, ch));
        }

        public static string ReversePrefix(string word, char ch)
        {
            // Get index of the char from which we would reverse the word
            int chIndex = word.IndexOf(ch);

            // Get the part of the word to reverse
            string subWord = word.Substring(0, chIndex + 1);

            // Get the rest of the word so we can add it later
            string abandonedWord = word.Substring(chIndex + 1);

            // Reverse the word 
            char[] reverse = subWord.ToCharArray();
            Array.Reverse(reverse);
            subWord = new string(reverse);

            // Combine the reversed word with the rest
            return subWord + abandonedWord;
        }
    }
}
