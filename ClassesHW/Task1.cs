namespace ClassesHW;

public class Task1
{
    public void Execute()
    {
        Phone James = new Phone();
        Phone John = new Phone("79995552211", "Motorola");
        Phone Jake = new Phone("78884443322", "Panasonic", 12.22);

        James.receiveCall("Mother");
        Console.WriteLine(James.getNumber());

        John.receiveCall("Father");
        Console.WriteLine(John.getNumber());

        Jake.receiveCall("Sister");
        Console.WriteLine(Jake.getNumber());

        James.SendMessage("79995552211", "78884443322");
        John.SendMessage("79995552211", "78884443322", "76665554433", "75554443322", "74443332211");
    }
}
