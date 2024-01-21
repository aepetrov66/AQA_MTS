using Task1;

public class Program
{
    public static void Main()
    {
        Figure[] figures =
        {
            FigureCreator.CreateFigure(12, 12, 12),
            FigureCreator.CreateFigure(3, 4, 5),
            FigureCreator.CreateFigure(12, 12, 13),
            FigureCreator.CreateFigure(3, 7, 5),
            FigureCreator.CreateFigure(12, 12),
            FigureCreator.CreateFigure(12, 13)
        };
        foreach (var fig in figures)
        {
            fig.GetInfo();
        }
    }
}