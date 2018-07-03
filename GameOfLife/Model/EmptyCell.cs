namespace GameOfLifeProject.Cs
{
    public sealed class EmptyCell : CellContent
    {
        public void Maintain() => NextCellContent = this;

        public void SpawnAmeba() => NextCellContent = new Ameba();
    }
}