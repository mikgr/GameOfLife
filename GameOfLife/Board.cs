using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeProject.Cs
{
    public sealed class Board
    {
        private readonly Random _rand = new Random();

        public Board(int width, int height)
        {
            Cells = InitCells(width, height).OrderBy(c => c.Top)
                                            .ThenBy(c => c.Left)
                                            .ToList();

            Cells.ForEach(c => c.SetNeighbours(GetNeighbours(c.Top, c.Left)));
        }

        public List<Cell> Cells { get; }

        private IEnumerable<Cell> InitCells(int height, int width) =>
            from top in Enumerable.Range(0, width)
            from left in Enumerable.Range(0, height)
            select Convert.ToBoolean(_rand.Next(2))
                ? new Cell(new Ameba(), top, left)
                : new Cell(new EmptyCell(), top, left);

        public IEnumerable<Cell> GetNeighbours(int top, int left) =>
            Cells
                .Where(c => (top - 1) <= c.Top && c.Top <= (top + 1))
                .Where(c => (left - 1) <= c.Left && c.Left <= (left + 1))
                .Where(c => c.Top != top || c.Left != left);

        public void ProceedToNextRound() =>
            Cells.ForEach(c => c.MoveNext());
    }
}