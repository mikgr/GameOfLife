using System.Threading.Tasks;

namespace GameOfLifeProject.Cs.Model
{
    public class Game
    {
        private readonly God _god;
        private readonly Board _board;
        private readonly IBoardPresenter _boardPresenter;

        public Game(God god, Board board, IBoardPresenter boardPresenter)
        {
            _god = god;
            _board = board;
            _boardPresenter = boardPresenter;

            _boardPresenter.Precent(_board);
        }

        public async Task Play(int clockSpeed)
        {
            while (true)
                await PlayRound(clockSpeed);
        }

        private async Task PlayRound(int clockSpeed)
        {
            Parallel.ForEach(_board.Cells, c => _god.PassJudgement(c));

            _board.ProceedToNextRound();

            _boardPresenter.Precent(_board);
            
            await Task.Delay(1000/clockSpeed);
        }
    }
}