using System;
using System.Collections.Generic;
using System.Linq;

namespace Other.Problems
{
    public class Box
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int? PartCount { get; set; }
        public Box(int id, int weight)
        {
            Id = id;
            Weight = weight;
        }
    }
    public class Part
    {
        public int BoxId { get; set; }
        public int PartNumber { get; set; }
        public int PartWeight { get; set; }
        public decimal PartCost => 50 + PartWeight * 7;
        public Part(int boxId, int partNumber, int partWeight)
        {
            BoxId = boxId;
            PartNumber = partNumber;
            PartWeight = partWeight;
        }
    }

    public static class WeightDivider
    {
        static List<Box> boxList = new List<Box>
        {
            new Box(123450, 3),
            new Box(123461, 8),
            new Box(123472, 11),
            new Box(123483, 3),
            new Box(123494, 13),
        };
        static readonly List<Part> partList = new List<Part>();
        static int currentMinimumPartCount = 2;

        public static void Solve()
        {
            boxList = boxList.OrderBy(b => b.Weight).ToList();
            while (!boxList.All(b => b.PartCount.HasValue))
            {
                var box = boxList.FirstOrDefault(b => !b.PartCount.HasValue);
                if (box.Weight % currentMinimumPartCount == 0)
                {
                    var partWeight = box.Weight / currentMinimumPartCount;
                    SetBoxParts(box, Enumerable.Repeat(partWeight, currentMinimumPartCount).ToArray());
                }
                else
                {
                    var splittedWeights = SplitWeights(box.Weight, currentMinimumPartCount);
                    var distinctWeights = splittedWeights.Distinct();
                    if (distinctWeights.Count() == 2 && Math.Abs(distinctWeights.First() - distinctWeights.Last()) == 1)
                    {
                        SetBoxParts(box, splittedWeights.ToArray());
                    }
                }
                currentMinimumPartCount++;
            }

            PrintToConsole();
        }

        private static void SetBoxParts(Box box, int[] partWeights)
        {
            for (int i = 0; i < currentMinimumPartCount; i++)
            {
                var part = new Part(box.Id, i + 1, partWeights[i]);
                partList.Add(part);
            }
            box.PartCount = currentMinimumPartCount;
        }
        private static List<int> SplitWeights(int totalWeight, int partCount)
        {
            var resultList = new List<int>();
            int mod = partCount - (totalWeight % partCount);
            int divideResult = totalWeight / partCount;
            for (int i = 0; i < partCount; i++)
            {
                if (i >= mod)
                    resultList.Add(divideResult + 1);
                else
                    resultList.Add(divideResult);
            }
            return resultList;
        }
        private static void PrintToConsole()
        {
            Console.WriteLine("BOX_ID   WEIGHT  PART_COUNT");
            foreach (var box in boxList)
            {
                Console.WriteLine($"{box.Id}    {box.Weight}          {box.PartCount}");
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("BOX_ID   PART_NUMBER  PART_WEIGHT    PART_COST");
            foreach (var part in partList)
            {
                Console.WriteLine($"{part.BoxId}        {part.PartNumber}            {part.PartWeight}           {part.PartCost}");
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine($"Total cost of all parts = {partList.Sum(x => x.PartCost)}$");

            Console.ReadLine();
        }
    }
}
