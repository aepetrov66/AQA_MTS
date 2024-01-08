namespace StringsHW;

public class Exersice6
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\6.txt";
        string toRemake = "Это    пример   строки,   содержащей\t   слова,   разделенные   одним\t   или   несколькими   пробелами   и/или   знаками   табуляции.";

        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        Console.WriteLine("Input:\t" + toRemake);

        char[] str = new char[toRemake.Length];

        for(int i = 0; i < toRemake.Length; i++)
        {
            if (toRemake[i] != '\t')
            {
                str[i] = toRemake[i];
            }
            else
            {
                str[i] = ' ';
            }
        }

        char[] str1 = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ' || str[i] == ' ' && str[i - 1] != ' ')
            {
                str1[i] = str[i];
            }
        }

        toRemake = new string(str1);

        Console.WriteLine("Output:\t" + toRemake);
        if (File.Exists(path))
        {
            File.AppendAllText(path, "\n" + toRemake);
        }
    }
}