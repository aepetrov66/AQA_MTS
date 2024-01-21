namespace Task1;

internal class RightAngled : Figure
{
    private static string type = "Прямоугольный треугольник";
    private static string formula = "S = (a * b) / 2";

    public RightAngled(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
    {
        base.type = type;
        base.formula = formula;
    }

    public override double Area()
    {
        return (sideA * sideB) / 2;
    }
}