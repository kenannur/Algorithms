using System.Text.RegularExpressions;

namespace Coderbyte.Problems
{
    public static class LongestWord
    {
        public static string Solve(string sen)
        {
            var words = sen.Split(' ');
            var longestWord = string.Empty;
            foreach (var word in words)
            {
                if (Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            return longestWord;
        }
    }
}
