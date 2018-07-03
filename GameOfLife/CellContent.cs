namespace GameOfLifeProject.Cs
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

        public abstract string Display();
    }
}