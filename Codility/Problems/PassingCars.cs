using System.Linq;

namespace Codility.Problems
{
    public static class PassingCars
    {
        public static int Solve(int[] A)
        {
            int count = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                var zeroCar = A[i];
                if (zeroCar == 0)
                {
                    for (int j = i + 1; j < A.Count(); j++)
                    {
                        var oneCar = A[j];
                        if (oneCar == 1)
                        {
                            count++;
                        }
                    }
                }
            }
            if (count > 1000000000)
            {
                count = -1;
            }
            return count;
        }
    }
}
