using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Problems
{
    public static class RepeatedString
    {
        public static long Solve(string s, long n)
        {
            if (s == "a")
            {
                return n;
            }
            var aCount = s.Count(x => x == 'a');
            var exactRepeatCount = n / s.Length;
            var mod = ((int)(n % s.Length));

            var aCountRemaining = s.Substring(0, mod).Count(x => x == 'a');

            return aCount * exactRepeatCount + aCountRemaining;
        }
    }
}
