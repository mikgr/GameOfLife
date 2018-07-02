namespace GameOfLifeProject.Cs
{
    public class EmptyCell : CellContent
    {
        public EmptyCell(int top, int left)
        {
            Top = top;
            Left = left;
        }

        public void Maintain() => NextCellContent = this;

        public void SpawnAmeba() => NextCellContent = new Ameba(Top, Left);
    }
}