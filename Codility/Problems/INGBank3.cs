using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems
{
    public static class INGBank3
    {
        public static void Solve(int N, int[] R, int[] C)
        {
            var bombPositions = new List<Coordinate>();
            for (int i = 0; i < R.Length; i++)
            {
                bombPositions.Add(new Coordinate(R[i], C[i]));
            }

            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    if (bombPositions.Any(c => c.Row == row && c.Column == column))
                    {
                        Console.Write("B");
                    }
                    else
                    {
                        var coordinate = new Coordinate(row, column);
                        var neigbors = coordinate.GetNeighborCoordinates(N);
                        var neigborBombCount = 0;
                        foreach (var neigbor in neigbors)
                        {
                            if (bombPositions.Any(c => c.Row == neigbor.Row && c.Column == neigbor.Column))
                            {
                                neigborBombCount++;
                            }
                        }
                        Console.Write(neigborBombCount);
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
    }

    struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public IEnumerable<Coordinate> GetNeighborCoordinates(int N)
        {
            var canIncreaseRow = Row < N - 1;
            var canIncreaseColumn = Column < N - 1;
            var canDecreaseRow = Row > 0;
            var canDecreaseColumn = Column > 0;

            var maxRow = canIncreaseRow ? Row + 1 : Row;
            var minRow = canDecreaseRow ? Row - 1 : Row;
            var maxColumn = canIncreaseColumn ? Column + 1 : Column;
            var minColumn = canDecreaseColumn ? Column - 1 : Column;

            for (int row = minRow; row <= maxRow; row++)
            {
                for (int column = minColumn; column <= maxColumn; column++)
                {
                    if (row != Row || column != Column)
                    {
                        yield return new Coordinate(row, column);
                    }
                }
            }
        }
    }
}
