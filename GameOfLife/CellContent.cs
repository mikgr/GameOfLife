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

        public int X { get; protected set; }

        public int Y { get; protected set; }

        public override string ToString() => Age < 10 ? $"{Age}" : "X";
    }
}