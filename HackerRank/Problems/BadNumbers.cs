using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class BadNumbers
    {
        public static void Solve()
        {
            var badNumbers = new List<int> { 37, 7, 22, 15, 49, 60 };
            int l = 3;
            int r = 48;

            badNumbers = badNumbers.Where(b => b < r && b > l).ToList();

            badNumbers.Add(l);
            badNumbers.Add(r);

            var orderedNumbers = badNumbers.OrderBy(x => x).ToList(); // (3) - 7 - 15 - 22 - 37 - (48)

            List<int> lengthList = new List<int>();
            for (int i = 0; i < orderedNumbers.Count - 1; i++)
            {
                var first = orderedNumbers[i];
                var second = orderedNumbers[i + 1];
                int length = 0;
                if (first == l && second == r)
                {
                    length = second - first + 1;
                }
                else if (first == l || second == r)
                {
                    length = second - first;
                }
                else
                {
                    length = second - first - 1;
                }
                lengthList.Add(length);
            }
            Console.WriteLine(lengthList.Max());
        }
    }
}
