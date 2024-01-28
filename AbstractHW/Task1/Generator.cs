using System.Diagnostics;

namespace Task1;

public static class Generator
{
    public static Figure[] GenFigureArray(int amount)
    {
        Figure[] array = new Figure[amount];
        for (int i = 0; i < amount; i++)
        {
            array[i] = GenFigure();
        }
        return array;

    }

    public static Figure GenFigure()
    {
        int spin = new Random().Next(0, 3);
        switch (spin)
        {
            case 0:
                int a = new Random().Next(1, 9);
                int b = new Random().Next(1, 9);
                int c = new Random().Next(1, 9);
                while (a >= (b + c) || b >= (a + c) ||  c >= (a + b))
                {
                    a = new Random().Next(1, 9);
                    b = new Random().Next(1, 9);
                    c = new Random().Next(1, 9);
                }
                return new Triangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));
            case 1: return new Rectangle(Convert.ToDouble(new Random().Next(1, 9)), Convert.ToDouble(new Random().Next(1, 9)));
            case 2: return new Circle(Convert.ToDouble(new Random().Next(1, 9)));
            default: return new Triangle(Convert.ToDouble(new Random().Next(1, 9)), Convert.ToDouble(new Random().Next(1, 9)), Convert.ToDouble(new Random().Next(1, 9)));
        }
    }
}
