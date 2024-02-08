namespace Task3;

public class ElectroEngine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Электроврум");
    }

    public override void Move()
    {
        Console.WriteLine("Электро движение вперед");
    }
    public override void Stop()
    {
        Console.WriteLine("Электро стоп");
    }
    public override void Right()
    {
        Console.WriteLine("Электро поворот направо");
    }
    public override void Left()
    {
        Console.WriteLine("Электро поворот налево");
    }
}
