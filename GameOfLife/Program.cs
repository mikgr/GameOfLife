using System;

namespace GameOfLifeProject.Cs
{
    class Program
    {
        static void Main()
        {
            var god = new God();
            var board = new Board(width: 150, height: 35);
            var boardPresenter  = new BoardPresenter();
            var gameOfLifeGame = new Game(god, board, boardPresenter);

            var gameTask = gameOfLifeGame.Play(clockSpeed: 8);

            Console.ReadLine();
        }
    }
}
