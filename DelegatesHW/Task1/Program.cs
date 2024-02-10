namespace Task1;

class Program
{
    delegate int Message();
    static void Main()
    {
        Message mes;
        mes = RandomInt;
        Console.WriteLine(mes());

        int RandomInt() => new Random().Next(0, 10);
    }
}