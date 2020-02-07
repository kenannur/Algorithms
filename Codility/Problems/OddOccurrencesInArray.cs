using System.Linq;

namespace Codility.Problems
{
    public static class OddOccurrencesInArray
    {
        public static int Solve(int[] A)
        {
            int result = 0;
            var groups = A.GroupBy(x => x);
            foreach (var group in groups)
            {
                if (group.Count() % 2 == 1)
                {
                    result = group.Key;
                }
            }
            return result;
        }
    }
}
