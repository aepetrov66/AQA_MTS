namespace ClassesHW;

public class Task2
{
    public void Execute()
    {
        CreditCard Bill = new CreditCard(4015702014656421, 100.50);
        CreditCard Brock = new CreditCard(4015777766665555, 146.12);
        CreditCard Billy = new CreditCard(4015555544443333, 1110.6);

        Bill.AddMoney(13.20);
        Brock.AddMoney(1000);
        Billy.TakeMoney(500.14);

        Bill.Info();
        Brock.Info();
        Billy.Info();
    }
}
