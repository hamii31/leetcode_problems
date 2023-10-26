namespace pascal_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            var result = Generate(rows);

            foreach ( var row in result )
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
        public static IList<IList<int>> Generate(int numRows)
        {
            int[] current = new int[] { 0, 1, 0 };

            IList<IList<int>> result = new List<IList<int>>
            {
                current.Where(x => x != 0).ToList()
            };

            for (int r = 1; r < numRows; ++r)
            {
                int[] next = new int[current.Length + 1];

                for (int c = 0; c < current.Length - 1; ++c)
                    next[c + 1] = current[c] + current[c + 1];

                current = next;

                result.Add(current.Where(x => x != 0).ToList());
            }

            return result;
        }
    }
}
