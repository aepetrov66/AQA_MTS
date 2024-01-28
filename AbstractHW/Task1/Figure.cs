namespace Task1;

public abstract class Figure
{
    public double sideA;
    public double sideB;
    public double sideC;
    public string type {  get; set; }
    public string formula {  get; set; }

    public Figure(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public virtual void getInfo()
    {
        Console.WriteLine($"""
            Тип: {this.type}
            Формула: {this.formula}
            Площадь: {getArea()}
            Периметр: {getPerimeter()}
            """);
    }

    public abstract double getArea();

    public abstract double getPerimeter();
}
