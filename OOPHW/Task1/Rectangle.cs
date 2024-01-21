namespace Task1;

public class Rectangle : Figure
{
    private static string formula = "S = a * b";

    public Rectangle(double sideA, double sideB) : base(sideA, sideB)
    {
        if (sideA == sideB)
        {
            base.type = "Квадрат";
        }
        else
        {
            base.type = "Прямоугольник";
        }
        base.formula = formula;
    }

    public override double Area()
    {
        return sideA * sideB;
    }
}