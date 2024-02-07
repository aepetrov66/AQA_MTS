namespace Task2;

internal class Program
{
    static void Main()
    {
        string input = "1, 2, 3, 4, 4, 5";
        string[] numbers = input.Split(',');
        List<int> uniqueNumbers = new List<int>();

        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            if (!uniqueNumbers.Contains(num))
            {
                uniqueNumbers.Add(num);
            }
        }

        string result = string.Join(", ", uniqueNumbers);
        Console.WriteLine(result);
    }
}