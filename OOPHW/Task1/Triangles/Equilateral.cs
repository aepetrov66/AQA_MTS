namespace Task1;

public class Equilateral : Figure
{
    private static string type = "Равносторонний треугольник";
    private static string formula = "S = (a^2 *  √3) / 4";

    public Equilateral(double sideA) : base(sideA, sideA, sideA)
    {
        base.type = type;
        base.formula = formula;
    }

    public override double Area()
    {
        return Math.Pow(sideA, 2) * Math.Sqrt(sideB) / 4;
    }
}
