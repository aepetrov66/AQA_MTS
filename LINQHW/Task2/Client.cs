namespace Task2;

internal class Client
{
    public static int id = 0;
    public int clientID;
    public int month;
    public int trainDuration;

    public Client(int month, int trainDuration)
    {
        this.clientID = id++;
        this.month = month;
        this.trainDuration = trainDuration;
    }
}
