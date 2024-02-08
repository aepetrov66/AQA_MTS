namespace Task2;

internal class Program
{
    static void Main()
    {
        GenericArray<int>.Add(10);
        GenericArray<int>.Add(20);
        GenericArray<int>.Add(30);
        GenericArray<double>.Add(40);
        GenericArray<double>.Add(50);
        GenericArray<double>.Add(60);
        GenericArray<String>.Add("70");
        GenericArray<String>.Add("80");
        GenericArray<String>.Add("90");
        GenericArray<Exception>.Add(new Exception("Пример1"));
        GenericArray<Exception>.Add(new Exception("Пример2"));
        GenericArray<Exception>.Add(new Exception("Пример3"));

        GenericArray<int>.Remove(1);
        GenericArray<int>.ShowArray();
        GenericArray<double>.Remove(1);
        GenericArray<double>.ShowArray();

        Console.WriteLine($"{GenericArray<Exception>.GetByIndex(1).Message}");
        Console.WriteLine($"{GenericArray<Exception>.GetByIndex(2).Message}");

    }
}