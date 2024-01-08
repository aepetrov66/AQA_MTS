namespace StringsHW; // Note: actual namespace depends on the project name.

public class Exersice2
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\2.txt";
        string toRemake;

        string[] array;

        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
            array = toRemake.Split(' ');
        }
        else
        {
            toRemake = "Welcome to the TMS lessons.";
            array = toRemake.Split(' ');
        }
        Console.WriteLine("Input:\t" + toRemake);


        toRemake = string.Join("\" \"", array);
        toRemake = "\"" + toRemake + "\"";

        Console.WriteLine("Output:\t" + toRemake);

        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + toRemake);
        }
    }
}
