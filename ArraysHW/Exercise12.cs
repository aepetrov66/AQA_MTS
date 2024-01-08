namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class TwelfthExercise
    {
        static void Main134(string[] args)
        {

            int sizeI;
            int sizeJ;

            Console.Write("Enter the array size A: ");
            sizeI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the array size B: ");
            sizeJ = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[sizeI, sizeJ];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(100);
                }
            }

            Console.WriteLine("Matrix:");
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            int[] sorted = new int[matrix.GetLength(1)];

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    sorted[j] = matrix[i, j];
                }
                Array.Sort(sorted);
                for (int j = 0; j <= sorted.GetUpperBound(0); j++)
                {
                    matrix[i, j] = sorted[j];
                }
            }

            Console.WriteLine("Matrix sorted:");
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
