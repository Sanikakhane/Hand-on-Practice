namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BooksCalculateStats()
    {
        /*
        //arrage
        var x = 5;
        var y = 6;
        var expected = 11;

        //act
        var actual = x + y;

        //assert
        Assert.Equal(expected, actual);
        */

        //arrage
        var book = new Book("");
        book.AddGrade(85.6);
        book.AddGrade(95.6);
        book.AddGrade(75.6);

        //act
        var result = book.GetStatistics();

        //assert
        Assert.Equal(95.6, result.High,1);
        Assert.Equal(75.6,result.Low,1);
        Assert.Equal(85.6, result.Average,1);



    }
}