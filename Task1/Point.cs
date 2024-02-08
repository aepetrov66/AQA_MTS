namespace Task1;

public class Point<T>
{
    public T x { get; set; }
    public T y { get; set; }

    public Point(T x, T y)
    {
        this.x = x;
        this.y = y;
    }

    public void ShowParameters()
    {
        Console.WriteLine($"""
            x: {this.x}, тип данных: {this.x.GetType().ToString()};
            y: {this.y}, тип данных: {this.y.GetType().ToString()}.
            ***
            """);
    }
}
