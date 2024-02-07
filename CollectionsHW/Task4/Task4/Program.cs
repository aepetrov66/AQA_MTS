using static System.Formats.Asn1.AsnWriter;

namespace Task4;

internal class Program
{
    static void Main()
    {
        Book book1 = new Book("1984", "Д.Оруэлл");
        Book book2 = new Book("Дивный новый мир", "О. Хаксли");
        Book book3 = new Book("Морской Волк", "Д. Лондон");
        Book book4 = new Book("Государь", "Н. Макиавелли");
        Book book5 = new Book("Либертарианство", "Д. Боуз");
        Book book6 = new Book("Первая научная история войны 1812", "М. Понасенков");
        Book book7 = new Book("Электроника шаг за шагом", "Р. Сворень");

        Reader reader1 = new Reader("И. Иванов");
        Reader reader2 = new Reader("П. Петров");
        Reader reader3 = new Reader("С. Сидоров");

        Library.AddBook(book1);
        Library.AddBook(book2);
        Library.AddBook(book3);
        Library.AddBook(book4);
        Library.AddBook(book5);
        Library.AddBook(book6);
        Library.AddBook(book7);
        Console.WriteLine("***");

        Library.CheckOutBook(reader1, book1);
        Library.CheckOutBook(reader1, book2);
        Library.CheckOutBook(reader1, book3);
        Library.CheckOutBook(reader2, book3);
        Library.CheckOutBook(reader2, book4);
        Library.CheckOutBook(reader2, book5);
        Library.CheckOutBook(reader3, book6);
        Console.WriteLine("***");

        Library.ShowReaders();
        Console.WriteLine("***");

        Library.ShowBooks();
        Console.WriteLine("***");

        Library.ReturnBook(reader1, book1);
        Library.ReturnBook(reader1, book2);
        Library.ReturnBook(reader2, book4);
        Console.WriteLine("***");

        Library.ShowBooks();
        Console.WriteLine("***");
    }
}