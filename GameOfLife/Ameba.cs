namespace GameOfLifeProject.Cs
{
    public class Ameba : CellContent
    {
        public void Survive() => NextCellContent = this;

        public void Die() => NextCellContent = new EmptyCell();

        public override string Display() => Age < 10 ? $"{Age}" : "X";
    }
}