using System.IO;

namespace StringsHW;

public class Exersice4
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\4.txt";
        string toRemake = "Плохой день!";

        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        Console.WriteLine("Input:\t" + toRemake);

        toRemake = toRemake.Substring(toRemake.IndexOf(" "));

        toRemake = toRemake.Insert(0, "Хороший");

        toRemake = toRemake.Insert(toRemake.Count(), "!!!!!!!!.");

        Console.WriteLine("Output:\t" + toRemake);

        toRemake = toRemake.Remove(toRemake.LastIndexOf('!'), 1);

        toRemake = toRemake.Insert(toRemake.LastIndexOf('!')+1, "?");

        Console.WriteLine("Output:\t" + toRemake);

        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + toRemake);
        }


    }
}