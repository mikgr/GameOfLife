using System.Linq.Expressions;

namespace GameOfLifeProject.Cs
{
    public class Cell
    {
        public Cell(CellContent cellContent, int top, int left)
        {
            CellContent = cellContent;
            Top = top;
            Left = left;
        }

        public void MoveNext()
        {
            CellContent = CellContent.NextCellContent;
        }

        public CellContent CellContent { get; private set; }

        public int Top { get; protected set; }

        public int Left { get; protected set; }

    }

    // todo - separate cellcontent(top,left) from ameba / emptycell to -> cell
    public abstract class CellContent
    {
        private CellContent _nextCellContent;

        private int _age = 1;

        public CellContent NextCellContent
        {
            get => _nextCellContent;
            protected set
            {
                _nextCellContent = value;
                _age++;
            }
        }

        public int Age => _age;

        
        public override string ToString() => Age < 10 ? $"{Age}" : "X";
    }
}