namespace Task4;

class Program
{
    delegate double DoubleResult(double radius);
    static void Main()
    {
        void ConsolePrint(Event holiday) => Console.WriteLine($"Сегодня отмечается {holiday.title}, посвященный {holiday.description}");

        Calendar clnd = new Calendar();
        clnd.RegisterNotifier(ConsolePrint);

        clnd.AddEvent(new Event("Праздник", DateTime.Now, "Веселый праздник"));
        clnd.AddEvent(new Event("Праздник1", DateTime.Now.AddDays(-1), "Очень веселый праздник"));
        clnd.AddEvent(new Event("Праздник2", DateTime.Now.AddDays(+1), "Самый веселый праздник"));

        clnd.Notification();
    }
}