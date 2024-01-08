using System.Text.RegularExpressions;

namespace StringsHW;

public class Exersice1
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\1.txt";
        string toRemake;

        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        else
        {
            toRemake = "165464564 test 64546546546 test hou4654654654se test ball 465465465 test 6546543216 64654654654dinner test654652316946";
        }

        Console.WriteLine("Input:\t" +  toRemake);

        toRemake = toRemake.Replace("test", "testing");
        toRemake = Regex.Replace(toRemake, @"\d+", "");

        //убрать более двух пробелов подряд в строке
        toRemake = Regex.Replace(toRemake, @"\s+", " ");
        //убрать лишний пробел в начале
        if (toRemake[0] == ' ')
        {
            toRemake = toRemake.Remove(0, 1);
        }

        Console.WriteLine("Output:\t" + toRemake);
        
        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + toRemake);
        }
    }
}
