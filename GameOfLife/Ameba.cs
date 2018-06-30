namespace GameOfLifeProject.Cs
{
    public class Ameba : CellContent
    {
        public Ameba(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Survive() => NextCellContent = this;

        public void Die() => NextCellContent = new EmptyCell(X, Y);
    }
}