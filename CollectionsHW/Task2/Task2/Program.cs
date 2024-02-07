namespace Task2;

internal class Program
{
    static void Main()
    {
        Store.AddProduct("Яблоки", 120.12, 2);
        Store.AddProduct("Вишня", 173.17, 15.5);
        Store.AddProduct("Абрикосы", 120, 2);
        Store.AddProduct("Бананы", 98, 6.3);

        ShowMenu();
        while (true)
        {
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.Write("Наименование: ");
                    string name = Console.ReadLine();
                    Console.Write("Цена: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Количество: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Store.AddProduct(name, price, amount);
                    break;
                case "2":
                    Store.ShowProducts();
                    break;
                case "3":
                    Console.Write("Введите id: ");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    Store.SearchByID(id3);
                    break;
                case "4":
                    Console.Write("Введите id: ");
                    int id4 = Convert.ToInt32(Console.ReadLine());
                    Store.UpdateInfo(id4);
                    break;
                case "5":
                    Console.Write("Введите id: ");
                    int id5 = Convert.ToInt32(Console.ReadLine());
                    Store.RemoveByID(id5);
                    break;
                case "6":
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
            1. Добавление товара;
            2. Отображение списка товаров;
            3. Поиск товара по идентификатору;
            4. Обновление информации о товаре;
            5. Удаление товара;
            6. Показать меню.
            """);
    }
}