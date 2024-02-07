using System.Diagnostics;
using System.Xml.Linq;

namespace Task2
{
    public static class Store
    {
        public static Dictionary<int, Product> catalogue = new Dictionary<int, Product>();

        public static void AddProduct(string name, double price, double amount)
        {
            Product product = new Product(name, price, amount);
            catalogue.Add(product.productID, product);
        }

        public static void ShowProducts()
        {
            foreach (var product in catalogue)
            {
                Console.WriteLine($"""
                    ID: {product.Key}
                    Наименование: {product.Value.name}
                    Цена: {product.Value.price}
                    Количество: {product.Value.amount} кг
                    """
                );
            }
        }

        public static void SearchByID(int id)
        {
            Console.WriteLine($"""
                    Наименование: {catalogue[id].name}
                    Цена: {catalogue[id].price}
                    Количество: {catalogue[id].amount} кг
                    """);
        }

        public static void RemoveByID(int id)
        {
            catalogue.Remove(id);
        }

        public static void UpdateInfo(int id)
        {
            string? priceStr;
            double priceDbl;
            for (int attempt = 0; attempt < 10; attempt++)
            {
                Console.Write("Укажите новую цену: ");
                priceStr = Console.ReadLine();
                if (priceStr == null || priceStr.Length == 0)
                {
                    break;
                }
                else if(Double.TryParse(priceStr, out priceDbl))
                {
                    catalogue[id].price = priceDbl;
                    break;
                }
                else { continue; }
            }

            string? amountStr;
            double amountDbl;
            for (int attempt = 0; attempt < 10; attempt++)
            {
                Console.Write("Укажите актуальное количество: ");
                amountStr = Console.ReadLine();
                if (amountStr == null || amountStr.Length == 0)
                {
                    break;
                }
                else if (Double.TryParse(amountStr, out amountDbl))
                {
                    catalogue[id].amount = amountDbl;
                    break;
                }
                else { continue; }
            }

            Console.WriteLine("Товар сохранен:");
            SearchByID(id);
        }

    }
}
