namespace Task4
{
    public static class Library
    {
        public static List<Book> books = new List<Book>();
        public static Dictionary<Reader, ISet<Book>> readers = new Dictionary<Reader, ISet<Book>>();

        public static void AddBook(Book book)
        {
            Console.WriteLine($"В библиотеку добавлена книга {book.title}, {book.author}");
            books.Add(book);
        }

        public static bool CheckOutBook(Reader reader, Book book)
        {
            foreach (var item in readers)
            {
                if (item.Value.Contains(book))
                {
                    Console.WriteLine($"Книга {book.title} уже находится у читателя {item.Key.name}, номер карты {item.Key.libraryCardNumber}");
                    return false;
                }
            }
            readers[reader].Add(book);
            books.Remove(book);
            Console.WriteLine($"Книга {book.title} успешно добавлена читателю {reader.name}, номер карты {reader.libraryCardNumber}");
            return true;
        }

        public static void ReturnBook(Reader reader, Book book)
        {
            readers[reader].Remove(book);
            books.Add(book);
            Console.WriteLine($"Книга {book.title} возвращена читателем {reader.name}, номер карты {reader.libraryCardNumber}");
        }

        public static void ShowBooks()
        {
            foreach (Book item in books)
            {
                Console.WriteLine($"""
                    id: {item.isbn}
                    Название: {item.title}
                    Автор: {item.author}
                    """);
            }
        }

        public static void ShowReaders()
        {
            foreach (var item in readers)
            {
                Console.WriteLine($"""
                    Читатель: {item.Key.name}, номер карты {item.Key.libraryCardNumber}
                    Книги: 
                    """);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"\t{item2.title}, {item2.author}");
                }
            }
        }
    }
}
