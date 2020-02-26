using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Problems
{
    public static class NewYearChaos
    {
        public static void Solve(int[] q)
        {
            var result = string.Empty;
            for (int i = 0; i < q.Length; i++)
            {
                var currentPosition = i;
                var toBePosition = q[i] - 1;
                var distance = Math.Abs(currentPosition - toBePosition);
                if (distance > 2)
                {
                    result = "Too chaotic";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
