using System.Reflection;

namespace Task_1;

public class Book
{
    public string Title{get; set;}
    public string Author{get; set;}
    public int Year{get; set;}

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public Book(){}

    public void GetInfo()
    {
        System.Console.WriteLine($"Book : {Title}\nAuthor : {Author}\nPrinted in : {Year}");
    }
    public bool IsPublishedRecently()
    {
        if (Year>2010) return true;
        else return false;
    }
}
