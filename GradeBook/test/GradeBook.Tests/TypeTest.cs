namespace GradeBook.Tests;

public class TypeTest
{
    [Fact]
    public void stringPassedByrefernce()
    {
        string str = "book";

        SetString(str, "New name");

        Assert.Equal(str,"book");
    }

    private void SetString(string str, string value)
    {
        return value;
    }


    [Fact]
    public void test1()
    {
        var x = GetInt();

        setInt(out x);

        Assert.Equal(x, 42);
    }
     

    [Fact]
    public void CSharpIsPassByValue()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1,"New name");

        Assert.Equal("Book 1",book1.Name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        var book1 = GetBook("Book 1");
        setName( book1, "newName");

        Assert.Equal("newName", book1.Name);
    }



    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1",book1.Name);
        Assert.Equal("Book 2", book2.Name);


    }

    [Fact]
    public void TwoVariablesReferncetwoSameObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 1", book2.Name);

        Assert.Same(book1, book2);

        Assert.True(object.ReferenceEquals(book1, book2));  

    }
    private void GetBookSetName( Book book, string name)
    {
        book = new Book(name);
    }
    private void setName(Book book, string name)
    {
        book.Name = name;
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
    private void setInt(out int x)
    {
        x = 42;
    }
    private int GetInt()
    {
        return 3;
    }

}