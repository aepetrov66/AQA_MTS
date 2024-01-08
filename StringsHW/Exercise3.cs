namespace StringsHW; // Note: actual namespace depends on the project name.

public class Exersice3
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\3.txt";
        string toRemake;


        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        else
        {
            toRemake = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        }
        Console.WriteLine("Input:\t" + toRemake);

        string secondString = toRemake.Substring(toRemake.IndexOf("abc")+3);
        string firsString = toRemake.Replace(toRemake.Substring(toRemake.IndexOf("abc")), "");

        Console.WriteLine("Output:\n" + "First string:\t" + firsString + "\n" + "Second string:\t" + secondString);
        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + "First string:\t" + firsString + "\n" + "Second string:\t" + secondString);
        }

    }
}