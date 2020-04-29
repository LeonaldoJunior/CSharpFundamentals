using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //-- Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var expected = new Statistics();
            expected.Average = 85.6;
            expected.Low     = 77.3;
            expected.High    = 90.5;
            //-- Act
            var actual = book.GetStatistics();

            //-- Assert
            Assert.Equal(expected.Average, actual.Average, 1);
            Assert.Equal(expected.Low, actual.Low);
            Assert.Equal(expected.High, actual.High);

        }
    }
}
