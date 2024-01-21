using Task;

namespace Task3;

public static class TransportService
{
    public static void PrintTransportType(Transport transport)
    {
        Console.WriteLine(transport.Type);
    }

    public static void PrintInfo(PublicTransport publicTransport)
    {
        Console.WriteLine($"""
            Тип: {publicTransport.Type}
            Направление: {publicTransport.destination}
            Номер: {publicTransport.number}
            Время отправления: {publicTransport.departureTime}
            Мест: {publicTransport.passengers}
            ***
            """);
    }

    public static PublicTransport[] GenData(int amount)
    {
        PublicTransport[] data = new PublicTransport[amount];
        for(int item = 0; item < data.Length; item++)
        {
            data[item] = GetRandomTransport();
            data[item].destination = GetRandomDestination();
            data[item].number = new Random().Next(1, 100);
            data[item].departureTime = DateTime.Today.AddHours(new Random().Next(-6, 6));
            data[item].passengers = new Random().Next(54, 200);
        }
        return data;
    }

    public static PublicTransport GetRandomTransport()
    {

        int spin = new Random().Next(0, 3);
        switch (spin)
        {
            case 0: return new Bus();
            case 1: return new Subway();
            case 2: return new Tramcar();
            case 3: return new Trolleybus();
            default: return new Bus();
        }
    }
    public static string GetRandomDestination()
    {

        int spin = new Random().Next(0, 3);
        switch (spin)
        {
            case 0: return "Москва";
            case 1: return "Санкт-Петербург";
            case 2: return "Екатеринбург";
            case 3: return "Нижний новгород";
            default: return "Верхние салды";
        }
    }
}
