using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class HourglassSum
    {
        public static int Solve(int[][] arr)
        {
            var total = -100;
            for (var y = 0; y <= 3; y++)
            {
                for (var x = 0; x <= 3; x++)
                {
                    var sum = arr[y][x] + arr[y][x + 1] + arr[y][x + 2];
                    sum += arr[y + 1][x + 1];
                    sum += arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];
        
                    if (total < sum)
                        total = sum;
                }
            }
            return total;
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
