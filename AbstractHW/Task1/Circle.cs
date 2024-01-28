namespace Task1;

internal class Circle : Rectangle
{
    public Circle(double sideA) : base(sideA, 0)
    {
        base.type = "Круг";
        base.formula = "S = pi * r^2";
    }

    public override double getArea()
    {
        return Math.Pow(sideA, 2) * Math.PI;
    }

    public override double getPerimeter()
    {
        return 2 * Math.PI * sideA;
    }
}
