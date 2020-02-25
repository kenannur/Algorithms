using System.Collections.Generic;
using System.Diagnostics;

namespace HackerRank.Problems
{
    public static class SubstringCalculator
    {
        public static long Solve(string s)
        {
            var sw = Stopwatch.StartNew();
            var resultCount = 0;
            var stringLength = s.Length;
            for (int substringLength = 1; substringLength <= stringLength; substringLength++)
            {
                var substrings = new HashSet<string>();
                var substringCount = stringLength - substringLength + 1;
                for (int j = 0; j < substringCount; j++)
                {
                    var substring = s.Substring(j, substringLength);
                    substrings.Add(substring);
                }
                resultCount += substrings.Count;
                substrings.Clear();
            }
            sw.Stop();
            return resultCount;
        }
    }
}
