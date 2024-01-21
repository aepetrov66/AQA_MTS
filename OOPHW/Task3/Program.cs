using Task3;

public class Program
{

    public static void Main()
    {
        PublicTransport[] array = TransportService.GenData(10);

        array = array.OrderBy(transport => transport.passengers).ToArray();
        foreach (var item in array)
        {
            TransportService.PrintInfo(item);
        }

        Console.WriteLine("Введите пункт назначения:");
        string usrDestination = Console.ReadLine();

        foreach (var item in array)
        {
            if (usrDestination.Equals(item.destination))
            {
                TransportService.PrintInfo(item);
            }
        }

        Console.WriteLine("Введите время отправления");
        string usrDateTime = Console.ReadLine();

        foreach (var item in array)
        {
            if (DateTime.Parse(usrDateTime) < item.departureTime)
            {
                TransportService.PrintInfo(item);
            }
        }

    }
}