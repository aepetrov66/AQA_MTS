namespace Task1;

public abstract class Figure
{
    public double sideA;
    public double sideB;
    public double sideC = 0;

    public string type;
    public string formula;
    public abstract double Area();

    public Figure(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public Figure(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public void GetInfo()
    {
        Console.WriteLine("Объект: {0}\nСторона А: {1}, Сторона B: {2}, Сторона C: {3}\nПлощадь: {4}\n------\n", this.type, this.sideA, this.sideB, this.sideC, Area());
    }
}

