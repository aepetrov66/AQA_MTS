namespace Task4;

public class Truck : Auto
{
    public bool trailer { get; set; } = false;
    public Truck(string brand, string number, double speed, double loadCapacity, bool sidecar) : base(brand, number, speed, loadCapacity)
    {
        this.trailer = sidecar;
        if (trailer)
        {
            base.loadCapacity = loadCapacity * 2;
        }
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Наличие прицепа: {this.trailer}");
    }
}