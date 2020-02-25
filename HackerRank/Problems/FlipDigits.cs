using System;
namespace HackerRank.Problems
{
    public static class FlipDigits
    {
        public static int Solve(string target)
        {
            var counter = 0;
            for (int i = 0; i < target.Length - 1; i++)
            {
                if (target[i] != target[i + 1])
                {
                    counter++;
                }
            }
            if (target[0] == '1')
            {
                counter++;
            }
            return counter;
        }   
    }
}
