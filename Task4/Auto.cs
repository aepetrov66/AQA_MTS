namespace Task4;

public abstract class Auto
{
    public string brand;
    public string number;
    public double speed;
    public double loadCapacity;

    public Auto(string brand, string number, double speed, double loadCapacity)
    {
        this.brand = brand;
        this.number = number;
        this.speed = speed;
        this.loadCapacity = loadCapacity;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"""
            Марка машины: {this.brand}
            Номер: {this.number}
            Максимальная скорость: {this.speed} км/ч
            Грузоподъемность: {this.loadCapacity} кг
            """);
    }
}
