using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeProject.Cs
{
    public class Board
    {
        private readonly Random _rand = new Random();
        private List<CellContent> _cells;

        public Board(int width, int height) => 
            _cells = InitCells(width, height).ToList();

        public List<CellContent> Cells => _cells;

        private IEnumerable<CellContent> InitCells(int width, int height) =>
            from x in Enumerable.Range(0, height)
            from y in Enumerable.Range(0, width)
            select Convert.ToBoolean(_rand.Next(2))
                ? (CellContent)new Ameba(x, y)
                : (CellContent)new EmptyCell(x, y);

        public IEnumerable<CellContent> GetNeighbours(int cx, int cy) =>
            Cells
                .Where(c => (cx - 1) <= c.X && c.X <= (cx + 1))
                .Where(c => (cy - 1) <= c.Y && c.Y <= (cy + 1))
                .Where(c => c.X != cx || c.Y != cy);

        public void ProceedToNextRound() =>
            _cells = _cells.Select(c => c.NextCellContent).ToList();
    }
}