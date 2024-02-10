namespace Task2;

class Program
{
    delegate double DoubleResult(double radius);
    static void Main()
    {
        double radius = 5;
        Rad rad = new Rad();
        DoubleResult? doubleResult = rad.Circumference;
        doubleResult += rad.CircleArea;
        doubleResult += rad.BallValue;

        doubleResult(radius);
    }
}