using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeProject.Cs
{
    public class BoardPresenter : IBoardPresenter
    {
        public void Precent(Board board) => PrintBoard(board.Cells);

        private void PrintBoard(IEnumerable<Cell> sortedCellContent)
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

                viewBuilder.Append(cell.CellContent is Ameba ? cell.CellContent.ToString() : " ");
            }

            Console.Write(viewBuilder.ToString());
            Console.SetCursorPosition(0, 0);
        }
    }
}