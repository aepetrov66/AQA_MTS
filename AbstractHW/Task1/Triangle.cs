namespace Task1;

public class Triangle : Figure
{
    public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
    {
        base.type = "Треугольник";
        base.formula = "S = √(p(p - a)(p - b)(p - c)), p = (a + b + c)/2";
    }

    public override double getArea()
    {
        double p = (sideA + sideB + sideC) / 2.0;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    public override double getPerimeter()
    {
        return sideA + sideB + sideC;
    }
}
