using System;
using System.Linq;

namespace Codility.Problems
{
    public static class MissingInteger
    {
        public static int Solve(int[] A)
        {
            int result = 1;
            for (int i = 1; i <= 1000001; i++)
            {
                if (!A.Contains(i))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
