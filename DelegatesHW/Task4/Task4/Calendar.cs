namespace Task4;

// Объявляем делегат
public delegate void Notifier(Event holyday);
public class Calendar
{
    Notifier? notifier;

    public List<Event> holydays = new List<Event>();
    
    public void AddEvent(Event holiday)
    {  holydays.Add(holiday); }
    
    public void RegisterNotifier(Notifier notifier)
    {
        this.notifier = notifier;
    }

    public void Notification()
    {
        foreach (Event e in holydays)
        {
            if (DateTime.Now.Date.Equals(e.date.Date))
            {
                notifier(e);
            }
            else
            {
                Console.WriteLine("Праздник не наступил");
            }
        }
    }
}