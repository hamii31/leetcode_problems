public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
				char[] chars = s.ToCharArray();
				Stack<char> stack = new Stack<char>();
				foreach (var item in chars)
				{
					stack.Push(item);
				}
				string reversedS = new string(stack.ToArray());

				return s.Equals(reversedS);
    }
}
