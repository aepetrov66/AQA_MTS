namespace Task2;

public class Product
{
    private static int id = 0;

    public string name { get; set; }
    public double price { get; set; }
    public double amount { get; set; }
    public int productID { get; }

    public Product(string name, double price, double amount)
    {
        this.name = name;
        this.price = price;
        this.amount = amount;
        this.productID = id++;
    }
}