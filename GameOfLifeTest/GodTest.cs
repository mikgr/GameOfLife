using System;
using System.Collections.Generic;
using System.Text;
using GameOfLifeProject.Cs;
using Xunit;

namespace GameOfLifeTest.Cs
{
    public class GodTest
    {
        [Theory]
        [InlineData(typeof(Ameba), 0, typeof(EmptyCell))]
        [InlineData(typeof(Ameba), 1, typeof(EmptyCell))]
        [InlineData(typeof(Ameba), 2, typeof(Ameba))]
        [InlineData(typeof(Ameba), 3, typeof(Ameba))]
        [InlineData(typeof(Ameba), 4, typeof(EmptyCell))]
        [InlineData(typeof(Ameba), 5, typeof(EmptyCell))]
        [InlineData(typeof(EmptyCell), 0, typeof(EmptyCell))]
        [InlineData(typeof(EmptyCell), 1, typeof(EmptyCell))]
        [InlineData(typeof(EmptyCell), 2, typeof(EmptyCell))]
        [InlineData(typeof(EmptyCell), 3, typeof(Ameba))]
        [InlineData(typeof(EmptyCell), 4, typeof(EmptyCell))]
        public void PassJudgement(Type inputType, int neighbourCount, Type expectedNextCellContentType)
        {
            var cellContent = (CellContent)Activator.CreateInstance(inputType);
            God.PassJudgement(cellContent, neighbourCount);
            Assert.True(cellContent.NextCellContent.GetType() == expectedNextCellContentType);
        }
    }
}
