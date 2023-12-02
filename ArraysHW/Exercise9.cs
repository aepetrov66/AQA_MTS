using System.Numerics;

namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class NinthExercise
    {
        static void MainMain(string[] args)
        {
            int[,] a = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] b = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };

            int[,] ab = new int[a.GetLength(0), b.GetLength(1)];


            for (int i = 0; i <= ab.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ab.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= b.GetUpperBound(0); k++)
                    {
                        ab[i, j] += a[i, k] * b[k, j];
                    }
                }
            }



            for (int i = 0; i <= ab.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ab.GetUpperBound(1); j++)
                {
                    Console.Write($"{ab[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

