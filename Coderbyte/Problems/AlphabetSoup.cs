using System.Linq;

namespace Coderbyte.Problems
{
    /*
    Have the function AlphabetSoup(str) take the str string parameter being passed and 
    return the string with the letters in alphabetical order(ie.hello becomes ehllo). 
    
    Assume numbers and punctuation symbols will not be included in the string.
    */
    public static class AlphabetSoup
    {
        public static string Solve(string str)
        {
            return string.Join("", str.OrderBy(s => s));
        }
    }
}
