using System;

namespace HackerRank.Problems
{
    public static class RotLeft
    {
        // a is array, d is rotate left count
        public static int[] Solve(int[] a, int d)
        {
            var counter = 0;
            var resultArr = new int[a.Length];
            while(counter < d)
            {
                if (counter == 0)
                {
                    resultArr = RotateLeft(a);
                }
                else
                {
                    resultArr = RotateLeft(resultArr);
                }
                counter++;
            }
            return resultArr;
        }

        private static int[] RotateLeft(int[] arr)
        {
            var newArr = new int[arr.Length];
            Array.Copy(arr, 1, newArr, 0, arr.Length - 1);
            newArr[newArr.Length - 1] = arr[0];
            return newArr;
        }
    }
}
