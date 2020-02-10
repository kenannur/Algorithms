namespace Coderbyte.Problems
{
    /*
    Have the function LetterChanges(str) take the str parameter being passed and modify it 
    using the following algorithm.Replace every letter in the string with the letter following it in the alphabet 
    (ie.c becomes d, z becomes a). Then capitalize every vowel in this new string (a, e, i, o, u) and finally 
    return this modified string.
    */
    public static class LetterChanges
    {
        public static string Solve(string str)
        {
            var result = string.Empty;
            foreach (var character in str)
            {
                if (char.IsLetter(character))
                {
                    if (character == 'z' || character == 'Z')
                    {
                        result += 'A';
                        continue;
                    }
                    var nextCode = ((char)(character + 1)).ToString();
                    if (nextCode == "a" || nextCode == "e" || nextCode == "i" || nextCode == "o" || nextCode == "u")
                    {
                        nextCode = nextCode.ToUpperInvariant();
                    }
                    result += nextCode;
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
    }
}
