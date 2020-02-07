using System;

namespace Codility.Problems
{
    public static class SoftTech1
    {
        public static int Solve(int A, int B)
        {
            if (B < 0)
            {
                return 0;
            }
            if (A < 0)
            {
                A = 0;
            }
            while (!HasSquareRoot(A))
            {
                A++;
            }
            while (!HasSquareRoot(B))
            {
                B--;
            }
            return (int)Math.Sqrt(B) - (int)Math.Sqrt(A) + 1;
        }

        private static bool HasSquareRoot(int number)
        {
            var result = Math.Sqrt(number);
            var mod = result % 1;
            return mod < double.Epsilon;
        }
    }
}
