namespace GameOfLifeProject.Cs
{
    public sealed class God
    {
        public void PassJudgement(Cell cell) =>
            PassJudgement(cell.CellContent, cell.CountNeighbouringAmeba());

        public static void PassJudgement(CellContent cellContent, int neighbouringAmebaCount)
        {
            switch (cellContent)
            {
                case Ameba ameba:
                    PassJudgementOnAmeba(ameba, neighbouringAmebaCount);
                    break;

                case EmptyCell emptyCell:
                    DecideFutureOfEmptyCell(emptyCell, neighbouringAmebaCount);
                    break;
            }
        }

        private static void PassJudgementOnAmeba(Ameba ameba, int neighbouringAmebaCount)
        {
            switch (neighbouringAmebaCount)
            {
                case 0:
                case 1:
                    ameba.Die();
                    break;

                case 2:
                case 3:
                    ameba.Survive();
                    break;

                default:
                    ameba.Die();
                    break;
            }
        }

        private static void DecideFutureOfEmptyCell(EmptyCell emptyCell, int neighbouringAmebaCount)
        {
            if (neighbouringAmebaCount == 3)
                emptyCell.SpawnAmeba();
            else
                emptyCell.Maintain();
        }
    }
}