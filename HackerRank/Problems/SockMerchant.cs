using System.Linq;

namespace HackerRank.Problems
{
    public static class SockMerchant
    {
        public static int Solve(int n, int[] arr)
        {
            var result = 0;
            var groupedArray = arr.GroupBy(x => x).Where(g => g.Count() >= 2);
            foreach (var group in groupedArray)
            {
                var pairCount = group.Count() / 2;
                result += pairCount;
            }
            return result;
        }
    }
}
