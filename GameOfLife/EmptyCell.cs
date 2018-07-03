namespace GameOfLifeProject.Cs
{
    public class EmptyCell : CellContent
    {
        public void Maintain() => NextCellContent = this;

        public void SpawnAmeba() => NextCellContent = new Ameba();
    }
}