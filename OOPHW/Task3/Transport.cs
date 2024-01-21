namespace Task;

public abstract class Transport
{
    public abstract string Type { get; }
    public void PrintType()
    {
        Console.WriteLine(Type);
    }
}
