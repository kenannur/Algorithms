using System.Linq;

namespace Codility.Problems
{
    public static class SoftTech2
    {
        public static int Solve(int A)
        {
            var AStr = A.ToString();
            var resultStr = string.Empty;
            if (AStr.Length < 3)
            {
                return A;
            }
            while (AStr.Length > 0)
            {
                var first = AStr.First();
                var last = AStr.Last();
                if (AStr.Length == 1)
                {
                    resultStr += first;
                    AStr = AStr.Remove(0, 1);
                }
                else
                {
                    resultStr += first;
                    resultStr += last;
                    AStr = AStr.Remove(0, 1);
                    AStr = AStr.Remove(AStr.Length - 1, 1);
                }
            }
            return int.Parse(resultStr);
        }
    }
}
