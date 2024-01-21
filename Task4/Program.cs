using Task4;

public class Program
{

    public static void Main()
    {
        Auto[] cars = Generator.GenAutoArray(5);
        foreach (var item in cars)
        {
            item.PrintInfo();
            Console.WriteLine("***");
        }

        Console.Write("Введите необходимую грузоподъемность: ");
        double usrCapacity = Convert.ToDouble(Console.ReadLine());

        foreach (var item in cars)
        {
            if (item.loadCapacity > usrCapacity)
            {
                item.PrintInfo();
                Console.WriteLine("***");
            }
        }
    }
}