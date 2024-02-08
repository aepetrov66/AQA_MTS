namespace Task3;

public class GasEngine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Бензиновый врум");
    }
    public override void Move()
    {
        Console.WriteLine("Бензиновое движение вперед");
    }
    public override void Stop()
    {
        Console.WriteLine("Бензиновый стоп");
    }
    public override void Right()
    {
        Console.WriteLine("Бензиновый поворот направо");
    }
    public override void Left()
    {
        Console.WriteLine("Бензиновый поворот налево");
    }
}

