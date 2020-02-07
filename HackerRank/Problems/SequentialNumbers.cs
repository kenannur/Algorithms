using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class SequentialNumbers
    {
        public static void Solve()
        {
            List<int> arr = new List<int> { 4, 5, 6, 5, 4, 3 };
            var groupedList = arr.GroupBy(x => x).OrderBy(y => y.Count()).ThenBy(z => z.Key);
            foreach (var item in groupedList)
            {
                for (int i = 0; i < item.Count(); i++)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
