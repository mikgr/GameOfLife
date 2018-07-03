using System.Linq;
using GameOfLifeProject.Cs;
using Xunit;

namespace GameOfLifeTest.Cs
{
    public class BoardTest
    {
        [Theory]
        [InlineData(0, 0, 3)]
        [InlineData(9, 9, 3)]
        [InlineData(9, 0, 3)]
        [InlineData(0, 9, 3)]
        [InlineData(0, 1, 5)]
        [InlineData(2, 9, 5)]
        [InlineData(1, 1, 8)]
        [InlineData(2, 2, 8)]
        public void Getneighbours_countIsCorrect(int x, int y, int expectedCount)
        {
            var board = new Board(10, 10);

            var res = board.GetNeighbours(x, y);

            Assert.Equal(expectedCount, res.Count());
        }

        [Theory]
        // Top-right (0,0)
        [InlineData(0, 0, 0, 1, true)]
        [InlineData(0, 0, 1, 1, true)]
        [InlineData(0, 0, 1, 0, true)]
        [InlineData(0, 0, 0, 0, false)]
        [InlineData(0, 0, 2, 0, false)]

        //Middle (5,5)
        [InlineData(5, 5, 4, 4, true)]
        [InlineData(5, 5, 4, 5, true)]
        [InlineData(5, 5, 4, 6, true)]
        [InlineData(5, 5, 5, 4, true)]
        [InlineData(5, 5, 5, 6, true)]
        [InlineData(5, 5, 6, 4, true)]
        [InlineData(5, 5, 6, 5, true)]
        [InlineData(5, 5, 6, 6, true)]
        [InlineData(5, 5, 6, 7, false)]
        [InlineData(5, 5, 6, 3, false)]

        // Edge (9, 5)
        [InlineData(9, 5, 9, 4, true)]
        [InlineData(9, 5, 8, 4, true)]
        [InlineData(9, 5, 8, 5, true)]
        [InlineData(9, 5, 8, 6, true)]
        [InlineData(9, 5, 9, 6, true)]
        [InlineData(9, 5, 10, 6, false)]
        public void GetNeighboursTest(int cellX, int cellY, int neighbourX, int neighbourY, bool shouldExits)
        {
            var board = new Board(10, 10);

            var neighbours = board.GetNeighbours(cellX, cellY);

            var actual = neighbours.SingleOrDefault(c => c.Top == neighbourX && c.Left == neighbourY);

            var cellExists = actual != null;

            if (shouldExits)
                Assert.True(cellExists);
            else
                Assert.False(cellExists);
        }
    }
}