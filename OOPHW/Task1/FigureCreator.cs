namespace Task1;

public class FigureCreator
{
    public static Figure CreateFigure(double sideA, double sideB, double sideC)
    {
        if (sideA == sideB && sideB == sideC)
        {
            return new Equilateral(sideA);
        }
        else if ((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) == Math.Pow(sideC, 2) ||
                 (Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) == Math.Pow(sideB, 2) ||
                 (Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) == Math.Pow(sideA, 2)) 
        {
            return new RightAngled(sideA, sideB, sideC);
        }
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
        {
            return new Isosceles(sideA, sideB, sideC);
        }
        else
        {
            return new Scalene(sideA, sideB, sideC);
        }
    }

    public static Figure CreateFigure(double sideA, double sideB)
    {
        return new Rectangle(sideA, sideB);
    }
}
