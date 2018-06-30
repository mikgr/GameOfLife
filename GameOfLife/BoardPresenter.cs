using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeProject.Cs
{
    public class BoardPresenter : IBoardPresenter
    {
        public void Precent(Board board) => PrintBoard(board.Cells);

        private void PrintBoard(IEnumerable<CellContent> cells) =>
            cells.ToList().ForEach(c => PrintAtPos(c.X, c.Y, c is Ameba ? c.ToString() : " "));

        private static void PrintAtPos(int x, int y, string toPrint)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(toPrint);
        }
    }
}