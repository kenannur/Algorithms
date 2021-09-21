using System;
using System.Collections.Generic;
using System.Linq;
using Codility.Problems;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            MissingInteger.Solve(new int[] { 1, 3, 4, 2, 6 });
            BinaryGap.Solve(1041);
            PassingCars.Solve(new int[] { 0, 1, 1, 0, 0, 1, 1 });
            AbsDistinct.Solve(new int[] { -5, -3, -1, 0, 1, 3, 6 });
            MaxProductOfThree.Solve(new int[] { -5, 1, 2, -2, 5, 6 });
            OddOccurrencesInArray.Solve(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            SoftTech1.Solve(int.MinValue, int.MaxValue);
            SoftTech2.Solve(101);
            SoftTech3.Solve(3, new int[] { 1, 2, 3, 3, 1, 3, 1 });

            INGBank1.Solve(new int[] { 5, 11, 1, 3 }, new int[] { 6, 1, 3, 2 }, 7);

            Console.ReadLine();
        }
    } 
}
