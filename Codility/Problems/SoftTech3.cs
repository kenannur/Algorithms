namespace Codility.Problems
{
    public static class SoftTech3
    {
        public static int Solve(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M; i++)
                count[i] = 0;
            int maxOccurence = 1;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if (tmp >= maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                    count[A[i]] = tmp + 1;
                }
                else
                {
                    count[A[i]] = 1;
                }
            }
            return A[index];
        }
    }
}
