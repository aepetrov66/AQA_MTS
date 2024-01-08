namespace ClassesHW;

public class Terminal
{
    int hundred;
    int fivty;
    int twenty;

    public Terminal(int hundred, int fivty, int twenty)
    {
        this.hundred = hundred;
        this.fivty = fivty;
        this.twenty = twenty;
    }

    public void AddMoney(int hundred, int fivty, int twenty)
    {
        this.hundred += hundred;
        this.fivty += fivty;
        this.twenty += twenty;
    }

    public void GetAmount()
    {
        Console.WriteLine("""
            В банкомате:
                {0} 100 долларовых купюр,
                {1} 50 долларовых купюр,
                {2} 20 долларовых купюр
            """, this.hundred, this.fivty, this.twenty);
    }

    public bool TakeMoney(int money)
    {
        int count100 = money / 100;
        money = money % 100;
        int count50 = money / 50;
        money = money % 50;
        int count20 = money / 20;
        money = money % 20;
        if (money == 0)
        {

            this.hundred -= count100;
            this.fivty -= count50;
            this.twenty -= count20;
            Console.WriteLine("""
            Сумма будет выдана:
                {0} 100 долларовых купюр,
                {1} 50 долларовых купюр,
                {2} 20 долларовых купюр
            """, count100, count50, count20);

            return true;
        }
        else
        {
            Console.WriteLine("Ошибка введенной суммы.");
            return false;
        }


    }
}
