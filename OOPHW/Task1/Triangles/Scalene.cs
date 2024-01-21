namespace Task1;

public class Scalene : Figure
{
    private static string type = "Обычный треугольник";
    private static string formula = "S = √(p(p - a)(p - b)(p - c)), p = (a + b + c)/2";

    public Scalene(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
    {
        base.type = type;
        base.formula = formula;
    }

    public override double Area()
    {
        double p = (sideA + sideB + sideC)/ 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }
}
