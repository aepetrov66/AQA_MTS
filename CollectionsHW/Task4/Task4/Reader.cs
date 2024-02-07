namespace Task4;

public class Reader
{
    public static int id = 0;

    public string name;
    public int libraryCardNumber;

    public Reader(string name)
    {
        this.name = name;
        this.libraryCardNumber = id++;
        Library.readers.Add(this, new HashSet<Book>());
    }
}
