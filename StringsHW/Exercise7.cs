using System.Text.RegularExpressions;

namespace StringsHW; // Note: actual namespace depends on the project name.

public class Exersice7
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\7.txt";
        string toRemake = "Это    пример   строки,   содержащей\t   слова,   разделенные   одним\t   или   несколькими   пробелами   и/или   знаками   табуляции.";

        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        Console.WriteLine("Input:\t" + toRemake);

        toRemake = Regex.Replace(toRemake, @"\s+", " ");

        string[] words = toRemake.Split(new char[] { '\t', ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        toRemake = string.Join(" ", words);
        Console.WriteLine("Output:\t" + toRemake);
        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + toRemake);
        }
    }
}