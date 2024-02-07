namespace Task4;

public class Book
{
    private static int id = 0;

    public string title { get; set; }
    public string author { get; set; }
    public int isbn { get; }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.isbn = id++;
    }
}