using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeProject.Cs
{
    public class BoardPresenter : IBoardPresenter
    {
        public void Precent(Board board) => PrintBoard(board.Cells);

        private void PrintBoard(IEnumerable<CellContent> sortedCellContent)
        {
            var viewBuilder = new StringBuilder();
            var currentTop = 0;
            foreach (var cellContent in sortedCellContent)
            {
                if (cellContent.Top != currentTop)
                {
                    viewBuilder.Append(Environment.NewLine);
                    currentTop = cellContent.Top;
                }

                viewBuilder.Append(cellContent is Ameba ? cellContent.ToString() : " ");
            }

            Console.Write(viewBuilder.ToString());
            Console.SetCursorPosition(0, 0);
        }
    }
}