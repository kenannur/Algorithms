using System;

namespace Codility.Problems
{
    public static class INGBank2
    {
        public static int Solve(int[] A, int X, int Y)
        {
            var result = int.MaxValue;
            for (int index = 0; index < A.Length - ((X - 1) * Y); index++)
            {
                var total = 0;
                var innerIndex = index;
                for (int j = 0; j < X; j++)
                {
                    var indexItem = A[innerIndex];
                    total += indexItem;
                    innerIndex += Y;
                }
                if (total < result)
                {
                    result = total;
                }
            }
            return result;
        }
    }
}
