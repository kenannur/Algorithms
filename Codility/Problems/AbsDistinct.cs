using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems
{
    public static class AbsDistinct
    {
        public static int Solve(int[] A)
        {
            List<int> absList = new List<int>();
            foreach (var item in A)
            {
                absList.Add(Math.Abs(item));
            }
            absList = absList.Distinct().ToList();
            return absList.Count();
        }
    }
}
