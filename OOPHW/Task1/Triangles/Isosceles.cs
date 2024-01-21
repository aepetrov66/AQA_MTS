namespace Task1;

public class Isosceles : Figure
{
    private static string type = "Равнобедренный треугольник";
    private static string formula = "S = 1/2 * b√(a^2  - (b^2 / 4))";

    public Isosceles(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
    {
        base.type = type;
        base.formula = formula;
    }

    public override double Area()
    {
        if(sideA == sideB)
        {
            return 0.5 * sideC * Math.Sqrt(Math.Pow(sideA, 2) - (Math.Pow(sideC, 2) / 4));
        } else
        {
            return 0.5 * sideB * Math.Sqrt(Math.Pow(sideA, 2) - (Math.Pow(sideB, 2) / 4));
        }
    }
}