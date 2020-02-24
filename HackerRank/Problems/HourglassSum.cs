using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class HourglassSum
    {
        public static int Solve(int[][] arr)
        {
            var sumList = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var leftTop = arr[i][j];
                    var top = arr[i + 1][j];
                    var rightTop = arr[i + 2][j];
                    var center = arr[i + 1][j + 1];
                    var leftBottom = arr[i][j + 2];
                    var bottom = arr[i + 1][j + 2];
                    var rightBottom = arr[i + 2][j + 2];

                    var total = leftTop + top + rightTop + center + leftBottom + bottom + rightBottom;
                    sumList.Add(total);
                }
            }
            var result = sumList.Max();
            return result;
        }

        public static int[][] PrepareHourglassSumInput()
        {
            var arr = new int[6][];
            arr[0] = new int[6];
            arr[1] = new int[6];
            arr[2] = new int[6];
            arr[3] = new int[6];
            arr[4] = new int[6];
            arr[5] = new int[6];

            arr[0][0] = 1;
            arr[1][0] = 1;
            arr[2][0] = 1;
            arr[3][0] = 0;
            arr[4][0] = 0;
            arr[5][0] = 0;

            arr[0][1] = 0;
            arr[1][1] = 1;
            arr[2][1] = 0;
            arr[3][1] = 0;
            arr[4][1] = 0;
            arr[5][1] = 0;

            arr[0][2] = 1;
            arr[1][2] = 1;
            arr[2][2] = 1;
            arr[3][2] = 0;
            arr[4][2] = 0;
            arr[5][2] = 0;

            arr[0][3] = 0;
            arr[1][3] = 0;
            arr[2][3] = 2;
            arr[3][3] = 4;
            arr[4][3] = 4;
            arr[5][3] = 0;

            arr[0][4] = 0;
            arr[1][4] = 0;
            arr[2][4] = 0;
            arr[3][4] = 2;
            arr[4][4] = 0;
            arr[5][4] = 0;

            arr[0][5] = 0;
            arr[1][5] = 0;
            arr[2][5] = 1;
            arr[3][5] = 2;
            arr[4][5] = 4;
            arr[5][5] = 0;
            return arr;
        }
    }
}
