namespace Task1;

public static class Program
{
    public static void Main()
    {
        List<int> intNumbers = new List<int>() { 1, 2, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 2, 3, 2, 3, 4, 6, 7, 7, 10 };

        var resultList = (from i in intNumbers
                         where i % 2 == 0
                         select i).Distinct();
        
        foreach (int i in resultList)
        {
            Console.WriteLine(i);
        }
    }
}