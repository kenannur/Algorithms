﻿using System;
using Coderbyte.Problems;

namespace Coderbyte
{
    class Program
    {
        static void Main(string[] args)
        {

            _ = FindIntersection.Solve(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" });
            _ = QuestionsMarks.Solve("acc?7??sss?3rr1??????5");
            _ = AlphabetSoup.Solve("qwerty");
            _ = LongestWord.Solve("fun&!! time");
            _ = FirstFactorial.Solve(8);
            _ = FirstReverse.Solve("Hello world");
            _ = LetterChanges.Solve("hello*3");
            JsonCleaning.Solve();

            Console.ReadLine();
        }
    }
}
