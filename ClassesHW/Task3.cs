namespace ClassesHW;

public class Task3
{
    public void Execute()
    {
        Terminal terminal = new Terminal(100, 100, 100);
        terminal.GetAmount();

        terminal.AddMoney(3, 4, 7);
        terminal.GetAmount();

        terminal.TakeMoney(170);

        terminal.TakeMoney(1070);

        terminal.TakeMoney(2090);
        terminal.TakeMoney(2092);

        terminal.GetAmount();
    }

}
