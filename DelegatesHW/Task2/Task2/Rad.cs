namespace Task2;
public delegate double DoubleResult(double result);
public class Rad
{
    public double Circumference(double radius)
    {
        double circumference = 2.0 * Math.PI * radius;
        Console.WriteLine($"Длина окружности с радиусом r = {radius} равна {circumference}");
        return circumference;
    }

    public double CircleArea(double radius)
    {
        double circleArea = Math.PI * Math.Pow(radius,2);
        Console.WriteLine($"Площадь окружности с радиусом r = {radius} равна {circleArea}");
        return circleArea;
    }

    public double BallValue(double radius)
    {
        double ballValue = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Объем шара с радиусом r = {radius} равен {ballValue}");
        return ballValue;
    }
}
