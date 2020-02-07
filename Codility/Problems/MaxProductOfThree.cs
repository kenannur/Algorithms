using System.Linq;

namespace Codility.Problems
{
    public static class MaxProductOfThree
    {
        public static int Solve(int[] A)
        {
            if (A.Count() == 3)
            {
                return A[0] * A[1] * A[2];
            }
            var positives = A.Where(x => x > 0).OrderByDescending(y => y).ToArray();
            var negatives = A.Where(x => x < 0).OrderBy(x => x).ToArray();

            if (positives.Count() >= 3 && negatives.Any())
            {
                var positivesMax = positives[0] * positives[1] * positives[2];
                var otherMax = negatives[0] * negatives[1] * positives[0];
                if (positivesMax > otherMax)
                {
                    return positivesMax;
                }
                else
                {
                    return otherMax;
                }
            }
            else
            {
                if (negatives.Count() >= 2 && positives.Any())
                {
                    var otherMax = negatives[0] * negatives[1] * positives[0];

                }
                else
                {

                }
            }
            return 0;
        }
    }
}
