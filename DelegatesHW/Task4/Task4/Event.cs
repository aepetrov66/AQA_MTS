namespace Task4;

public class Event
{
    public string title {  get; set; }
    public DateTime date {  get; set; }
    public string description { get; set; }

    public Event(string title, DateTime date, string description)
    {
        this.title = title;
        this.date = date;
        this.description = description;
    }
}
