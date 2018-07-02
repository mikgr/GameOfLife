using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeProject.Cs
{
    public class Board
    {
        private readonly Random _rand = new Random();

        public Board(int width, int height) => 
            Cells = InitCells(width, height).OrderBy(c => c.Top).ThenBy(c => c.Left).ToList();

        public List<CellContent> Cells { get; private set; }

        private IEnumerable<CellContent> InitCells(int width, int height) =>
            from top in Enumerable.Range(0, height)
            from left in Enumerable.Range(0, width)
            select Convert.ToBoolean(_rand.Next(2))
                ? (CellContent)new Ameba(top, left)
                : (CellContent)new EmptyCell(top, left);

        public IEnumerable<CellContent> GetNeighbours(int top, int left) =>
            Cells
                .Where(c => (top - 1) <= c.Top && c.Top <= (top + 1))
                .Where(c => (left - 1) <= c.Left && c.Left <= (left + 1))
                .Where(c => c.Top != top || c.Left != left);

        public void ProceedToNextRound() =>
            Cells = Cells.Select(c => c.NextCellContent).ToList();
    }
}