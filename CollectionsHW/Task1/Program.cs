namespace Task1;

internal class Program
{
    static void Main()
    {
        Library.AddBook("1984", "Д.Оруэлл", 2012);
        Library.AddBook("Дивный новый мир", "О. Хаксли", 2005);
        Library.AddBook("Морской Волк", "Д. Лондон", 2007);
        Library.AddBook("Путешествие к центру земли", "Жюль Верн", 2005);

        ShowMenu();
        while (true)
        {
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Library.ShowBooks();
                    break;
                case "2":
                    Console.Write("Название: ");
                    string title = Console.ReadLine();
                    Console.Write("Автор: ");
                    string author = Console.ReadLine();
                    Console.Write("Год издания: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Library.AddBook(title, author, year);
                    break;
                case "3":
                    Console.Write("Автор: ");
                    string authorToFind = Console.ReadLine();
                    Library.FindBookByAuthor(authorToFind);
                    break;
                case "4":
                    Console.Write("Введите id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Library.DeleteBookById(id);
                    break;
                case "5":
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("""
            1. Вывести список досупной литературы;
            2. Добавление новой книги;
            3. Поиск книги по автору;
            4. Удаление книги по id;
            5. Показать меню.
            """);
    }
}