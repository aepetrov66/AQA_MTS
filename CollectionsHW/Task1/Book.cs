namespace Task1;

public class Book
{
    private static int id = 0;
    
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int BookId { get; }

    public Book(string title, string author, int year)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.BookId = id++;
    }
}
