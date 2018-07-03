using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeProject.Cs
{
    internal  sealed class BoardPresenter : IBoardPresenter
    {
        public void Precent(Board board) => PrintBoard(board.Cells);

        private static void PrintBoard(IEnumerable<Cell> sortedCellContent)
        {
            var viewBuilder = new StringBuilder();
            var currentTop = 0;

            foreach (var cell in sortedCellContent)
            {
                if (cell.Top != currentTop)
                {
                    viewBuilder.Append(Environment.NewLine);
                    currentTop = cell.Top;
                }

                viewBuilder.Append(cell.CellContent.Display());
            }

            Console.Write(viewBuilder.ToString());
            Console.SetCursorPosition(0, 0);
        }
    }
}