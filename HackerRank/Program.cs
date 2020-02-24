using HackerRank.Problems;
using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            BadNumbers.Solve();
            SequentialNumbers.Solve();
            _ = SockMerchant.Solve(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            _ = JumpingOnClouds.Solve(new int[] { 0, 0, 0, 1, 0, 0 });
            _ = RepeatedString.Solve("aba", 10);
            _ = HourglassSum.Solve(HourglassSum.PrepareHourglassSumInput());
            _ = RotLeft.Solve(new int[] { 1, 2, 3, 4, 5 }, 2);

            Console.ReadLine();
        }
    }
}
