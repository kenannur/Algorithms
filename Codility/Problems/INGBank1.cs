using System.Linq;

namespace Codility.Problems
{
    public static class INGBank1
    {
        public static int Solve(int[] D, int[] C, int P)
        {
            var orderedObjectList = D.Select((d, i) => new
            {
                Distance = d,
                Cost = C[i]
            }).OrderBy(x => x.Distance).ThenBy(x => x.Cost);

            var canRenderCount = 0;
            foreach (var obj in orderedObjectList)
            {
                if (obj.Cost > P)
                {
                    break;
                }
                canRenderCount++;
                P -= obj.Cost;
            }
            return canRenderCount;
        }
    }
}
