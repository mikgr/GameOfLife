namespace GameOfLifeProject.Cs.Model
{
    public sealed class EmptyCell : CellContent
    {
        public void Maintain() => NextCellContent = this;

        public void SpawnAmeba() => NextCellContent = new Ameba();
    }
}