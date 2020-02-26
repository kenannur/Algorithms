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
            _ = CountingValleys.Solve(8, "UDDDUDUU");
            _ = FlipDigits.Solve("1010");
            _ = SubstringCalculator.Solve("kinventich");
            NewYearChaos.Solve(new int[] { 2, 1, 5, 3, 4 });

            Console.ReadLine();
        }
    }
}
