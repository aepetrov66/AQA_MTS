namespace Task2;

public class Product: AbstractProduct
{
    public string name;
    public double price;
    public DateTime productionDate;
    public int shelfLifeInDays;

    public Product(string name, double price, DateTime productionDate, int shelfLifeInDays)
    {
        this.name = name;
        this.price = price;
        this.productionDate = productionDate;
        this.shelfLifeInDays = shelfLifeInDays;
    }

    public override void GetDescription()
    {
        Console.WriteLine($"""
            Наименование: {this.name}
            Цена: {this.price}
            Дата производства: {this.productionDate}
            Срок годности: {this.shelfLifeInDays}
            Срок годности не истек: {IsProductAllive()}
            """);
    }

    public override bool IsProductAllive()
    {
        return DateTime.Today < productionDate.AddDays(this.shelfLifeInDays);
    }
}
