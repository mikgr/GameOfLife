namespace GameOfLifeProject.Cs
{
    public class Ameba : CellContent
    {
        public Ameba(int top, int left)
        {
            Top = top;
            Left = left;
        }

        public void Survive() => NextCellContent = this;

        public void Die() => NextCellContent = new EmptyCell(Top, Left);
    }
}