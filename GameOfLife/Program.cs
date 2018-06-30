using System;

namespace GameOfLifeProject.Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var god = new God();
            var board = new Board(width: 100, height: 25);
            var boardPresenter  = new BoardPresenter();
            var gameOfLifeGame = new Game(god, board, boardPresenter);

            var gameTask = gameOfLifeGame.Play(clockSpeed: 5);

            Console.ReadLine();
        }
    }
}
