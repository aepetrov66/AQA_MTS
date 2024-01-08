using System.Text;
using System.Text.RegularExpressions;

namespace StringsHW;

public class Exercise5
{
    public void Execute()
    {
        string path = "C:\\Users\\Relat\\Desktop\\5.txt";
        string toRemake = "5551-aaa-1111-abc-1a2b";
        if (File.Exists(path))
        {
            toRemake = File.ReadAllText(path);
        }
        
        Console.WriteLine("Input:\t" + toRemake);

        Console.WriteLine("Два первых блока по 4 цифры:\t" + point1(toRemake));
        Console.WriteLine("Блоки из трех букв заменить на ***:\t" + point2(toRemake));
        Console.WriteLine("Буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре:\t" + point3(toRemake));
        Console.WriteLine("Буквы из номера документа в формате \"Letters:yyy/yyy/y/y\" в верхнем регистре:\t" + point4(toRemake));
        Console.WriteLine(point5(toRemake));
        Console.WriteLine(point6(toRemake));
        Console.WriteLine(point7(toRemake));

        string point1(string id)
        {
            string[] elements = toRemake.Split("-");

            string point1 = "";
            foreach (string element in elements)
            {
                if (Regex.IsMatch(element, @"\d{4}"))
                {
                    point1 += element + " ";
                }
            }
            point1 = point1.Remove(point1.Length - 1);
            return point1;
        }

        string point2(string id)
        {
            string point2 = Regex.Replace(toRemake, @"[a-zA-ZА-Яа-я]{3}", "***");
            return point2;
        }

        string point3(string id)
        {
            string point3 = Regex.Replace(toRemake, @"[^a-zA-ZА-Яа-я]", "/");
            point3 = Regex.Replace(point3, @"/{2,}", "/");
            point3 = point3.Remove(0, 1);
            point3 = point3.ToLower();
            return point3;
        }

        StringBuilder point4(string id)
        {
            id = point3(id);
            string[] elements = id.Split("/", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder results = new StringBuilder();
            return results.AppendJoin('/', elements);
        }
        string point5(string id)
        {
            id = id.ToLower();
            if (id.Contains("abc"))
            {
                return "Строка содержит abc";
            }
            else
            {
                return "Строка не содержит abc";
            }
        }
        string point6(string id)
        {
            string toCompare = "555";
            if (id.Substring(0,toCompare.Length).Equals(toCompare)){
                return "Строка начинается с \"555\"";
            }
            else
            {
                return "Строка не начинается с \"555\"";
            }
        }
        string point7(string id)
        {
            id = id.ToLower();
            string toCompare = "1a2b";
            if (id.Substring(id.Length - toCompare.Length).Equals(toCompare))
            {
                return "Строка заканчивается на 1a2b";
            }
            else
            {
                return "Строка не заканчивается на 1a2b";
            }
        }


    }
}
