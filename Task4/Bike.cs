namespace Task4;

public class Bike : Auto
{
    public bool sidecar { get; set; } = false;
    public Bike(string brand, string number, double speed, double loadCapacity, bool sidecar) : base(brand, number, speed, loadCapacity)
    {
        this.sidecar = sidecar;
        if (!sidecar)
        {
            base.loadCapacity = 0;
        }
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Наличие коляски: {this.sidecar}") ;
    }
}
