using System.Collections.Generic;
using System;
using System.Linq;

namespace GameOfLifeProject.Cs
{
    public sealed class Cell
    {
        private List<Cell> _neighbours;

        public Cell(CellContent cellContent, int top, int left)
        {
            CellContent = cellContent;
            Top = top;
            Left = left;
        }

        public CellContent CellContent { get; private set; }

        public int Top { get; private set; }

        public int Left { get; private set; }

        public List<Cell> NeighBours => _neighbours;

        public void SetNeighbours(IEnumerable<Cell> neighbours) =>
            _neighbours = _neighbours == null 
                        ? neighbours.ToList()
                        : throw new InvalidOperationException("Neighbours can only be assigned once");

        public int CountNeighbouringAmeba() =>
            _neighbours?.Count(c => c.CellContent is Ameba) ?? throw new InvalidOperationException("SetNeighbours(..) must be called");

        public void MoveNext() =>
            CellContent = CellContent.NextCellContent;
    }
}