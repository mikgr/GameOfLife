namespace GameOfLifeProject.Cs
{
    public abstract class CellContent
    {
        private CellContent _nextCellContent;

        private int _age = 1;

        public CellContent NextCellContent
        {
            get => _nextCellContent;
            protected set
            {
                _nextCellContent = value;
                _age++;
            }
        }

        public int Age => _age;

        public int Top { get; protected set; }

        public int Left { get; protected set; }

        public override string ToString() => Age < 10 ? $"{Age}" : "X";
    }
}