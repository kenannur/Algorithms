using System.Collections.Generic;

namespace HackerRank.Problems
{
    public static class JumpingOnClouds
    {
        public static int Solve(int[] c)
        {
            var current = 0;
            var path = new List<int>();

            while(current < c.Length - 1)
            {
                var temp = current + 2;
                if (temp < c.Length)
                {
                    if (c[temp] == 0)
                    {
                        path.Add(temp);
                        current += 2;
                    }
                    else
                    {
                        path.Add(current + 1);
                        current += 1;
                    }
                }
                else
                {
                    path.Add(current + 1);
                    current += 1;
                }
            }
            return path.Count;
        }
    }
}
