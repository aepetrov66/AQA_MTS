using Task2;

namespace Task1;

public static class Program
{
    public static void Main()
    {
        List<Client> clients = new List<Client>()
        {
            new Client(1, 1),
            new Client(2, 1),
            new Client(3, 1),
            new Client(4, 2),
            new Client(5, 3),
            new Client(6, 4),
            new Client(7, 4)
        };

        int minTrainDuration = (from i in clients select i.trainDuration).Min();

        Client clientWithMinimumTraiDuration = (from i in clients where i.trainDuration == minTrainDuration select i).Last();
        Console.WriteLine($"Минимальная продолжительность занятий ({clientWithMinimumTraiDuration.trainDuration} час) у клиента id = {clientWithMinimumTraiDuration.clientID} " +
            $"в {clientWithMinimumTraiDuration.month} месяце");

    }
}