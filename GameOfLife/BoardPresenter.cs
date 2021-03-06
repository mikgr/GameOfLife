﻿using System;
using System.Collections.Generic;
using System.Text;
using GameOfLifeProject.Cs.Model;

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

                viewBuilder.Append(
                    cell.CellContent is Ameba 
                    ? cell.CellContent.Age < 10 
                            ? cell.CellContent.Age.ToString() 
                            : "X" 
                    : " ");
            }

            Console.SetCursorPosition(0, 0);
            Console.Write(viewBuilder.ToString());
        }
    }
}