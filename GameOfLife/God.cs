using System.Linq;

namespace GameOfLifeProject.Cs
{
    public class God
    {
        public void PassJudgement(CellContent cellContent, Board board)
        {
            var neighbouringAmebaCount = board.GetNeighbours(cellContent.X, cellContent.Y)
                                              .Count(n => n is Ameba);

            PassJudgement(cellContent, neighbouringAmebaCount);
        }

        public static void PassJudgement(CellContent cellContent, int neighbouringAmebaCount)
        {
            switch (cellContent)
            {
                case Ameba ameba:
                    PassJudgementOnAmeba(ameba, neighbouringAmebaCount);
                    break;

                case EmptyCell emptyCell:
                    DecideFutureForEmptyCell(emptyCell, neighbouringAmebaCount);
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

        private static void DecideFutureForEmptyCell(EmptyCell emptyCell, int neighbouringAmebaCount)
        {
            if (neighbouringAmebaCount == 3)
                emptyCell.SpawnAmeba();
            else
                emptyCell.Maintain();
        }
    }
}