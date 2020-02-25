namespace HackerRank.Problems
{
    public static class RotLeft
    {
        // a is array, d is shift left count
        public static int[] Solve(int[] a, int d)
        {
            var newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                var newIndex = i - d;
                if (newIndex < 0)
                {
                    newIndex += a.Length;
                }
                newArray[newIndex] = a[i];
            }
            return newArray;
        }
    }
}
