using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;

namespace HackerRank.Problems
{
    public static class SubstringCalculator
    {
        public static long Solve(string s)
        {
            var stringList = new HashSet<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    var substring = s.Substring(i, j - i + 1);
                    if (!stringList.Contains(substring))
                    {
                        stringList.Add(substring);
                    }
                }
            }
            return stringList.Count;

            var length = s.Length;
            var totalSubstringCount = (length * (length + 1)) / 2;
            var duplicates = s.GroupBy(x => x).Where(y => y.Count() > 1);
            var duplicateCount = 0;
            foreach (var item in duplicates)
            {
                duplicateCount += item.Count() - 1;
            }
            var result = totalSubstringCount - duplicateCount;
            return result;
        }
    }
}
