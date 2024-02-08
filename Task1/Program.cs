namespace Task1;

internal class Program
{
    static void Main()
    {
        Point<int> point1 = new Point<int>(1, 1);
        Point<double> point2 = new Point<double>(1, 1);
        Point<string> point3 = new Point<string>("1", "1");
        Point<string?> point4 = new Point<string?>("1", "1");

        point1.ShowParameters();
        point2.ShowParameters();
        point3.ShowParameters();
        point4.ShowParameters();
    }
}