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
}