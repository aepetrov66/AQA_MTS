using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public static class Library
    {
        public static ArrayList library = new ArrayList();
        public static void AddBook(string title, string author, int year)
        {
            Book book  = new Book(title, author, year);
            library.Add(book);
        }

        public static void ShowBooks()
        {
            foreach (Book book in library)
            {
                Console.WriteLine($"""
                    id: {book.BookId}
                    Название: {book.Title}
                    Автор: {book.Author}
                    Год издания: {book.Year}
                    """);
            }
        }

        public static void FindBookByAuthor(string author)
        {
            foreach (Book book in library)
            {
                if (book.Author.ToLower().Contains(author.ToLower()))
                {
                    Console.WriteLine($"""
                    id: {book.BookId}
                    Название: {book.Title}
                    Автор: {book.Author}
                    Год издания: {book.Year}
                    """);
                }
            }
        }

        public static void DeleteBookById(int id)
        {
            int? index = null;
            foreach (Book book in library)
            {
                if (book.BookId == id)
                {
                    index = library.IndexOf(book);
                }
            }
            if (index != null)
            {
                library.RemoveAt((int)index);
            }
            else
            {
                throw new Exception("Id не найден");
            }
        }
    }
}
