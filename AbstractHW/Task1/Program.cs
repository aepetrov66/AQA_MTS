using Task1;

public class Program
{

    public static void Main()
    {
        Figure[] figures = Generator.GenFigureArray(15);
        foreach (var item in figures)
        {
            item.getInfo();
            Console.WriteLine("***");
        }
    }
}