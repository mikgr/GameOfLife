namespace GameOfLifeProject.Cs
{
    public class EmptyCell : CellContent
    {
        public EmptyCell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Maintain() => NextCellContent = this;

        public void SpawnAmeba() => NextCellContent = new Ameba(X, Y);
    }
}