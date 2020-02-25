namespace HackerRank.Problems
{
    public static class CountingValleys
    {
        // n = step count, s = Steps (UDDDUDUU) U = Up, D = Down
        public static int Solve(int n, string s)
        {
            var position = 0;
            var valleyCount = 0;
            foreach (var step in s)
            {
                if (step == 'U')
                    position++;
                else
                    position--;

                if (position == 0 && step == 'U')
                {
                    valleyCount++;
                }
            }
            return valleyCount;
        }
    }
}
