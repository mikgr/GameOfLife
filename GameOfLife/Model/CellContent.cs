namespace GameOfLifeProject.Cs.Model
{
    public abstract class CellContent
    {
        private CellContent _nextCellContent;

        public CellContent NextCellContent
        {
            get => _nextCellContent;
            protected set
            {
                _nextCellContent = value;
                Age++;
            }
        }

        public int Age { get; private set; } = 1;
    }
}