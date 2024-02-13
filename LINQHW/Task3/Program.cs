namespace Task2;


public static class Program
{
    public static void Main()
    {
        List<string> strings = new List<string>() { "BOUNCE", "DEER", "DANCE", "LOLIPOP", "YESTERDAY", "SUBMARINE", "RUSSIA", "SWEET", "HONEY" };

        var newStrings = (from i in strings orderby i descending select i).OrderBy(i => i.Length);

        foreach ( var i in newStrings)
        {
            Console.WriteLine(i);
        }
    }
}