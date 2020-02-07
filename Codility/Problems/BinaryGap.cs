using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems
{
    public static class BinaryGap
    {
        public static int Solve(int N)
        {
            string binary = Convert.ToString(N, 2);
            Console.WriteLine(binary);

            List<int> oneIndexes = new List<int>();
            int indexOfOne = 0;
            foreach (var character in binary)
            {
                if (character == '1')
                {
                    oneIndexes.Add(indexOfOne);
                }
                indexOfOne++;
            }

            int result;
            if (oneIndexes.Count == 0 || oneIndexes.Count == 1)
            {
                result = 0;
            }
            else
            {
                List<int> rangeList = new List<int>();
                foreach (var item in oneIndexes)
                {
                    int index = oneIndexes.IndexOf(item);
                    int nextIndex = index + 1;
                    if (nextIndex <= oneIndexes.Count - 1)
                    {
                        var nextItem = oneIndexes[nextIndex];
                        rangeList.Add(nextItem - item - 1);
                    }
                }
                result = rangeList.Max();
            }
            return result;
        }
    }
}
