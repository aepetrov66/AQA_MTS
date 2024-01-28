namespace Task1;

internal class Rectangle : Triangle
{
    public Rectangle(double sideA, double sideB) : base(sideA, sideB, 0)
    {
        base.type = "Прямоугольник";
        base.formula = "S = a * b";
    }

    public override double getArea()
    {
        return base.sideA * base.sideB;
    }

    public override double getPerimeter()
    {
        return (sideA + sideB) * 2;
    }
}
