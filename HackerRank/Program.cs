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
            Console.ReadLine();
        }
    }
}
