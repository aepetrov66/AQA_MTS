namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class FourthExercise
    {
        static void MainMain(string[] args)
        {

            int size = 5;

            int[] array1 = new int[size];
            int average1 = 0;
            int[] array2 = new int[size];
            int average2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(100);
                average1 += array1[i];
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = new Random().Next(100);
                average2 += array2[i];
            }

            average1 /= array1.Length;
            average2 /= array2.Length;

            Console.Write("{ ");
            foreach (int i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"}} Average = {average1}");

            Console.Write("{ ");
            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"}} Average = {average2}");

            if (average1 > average2)
            {
                Console.WriteLine("Average of the first array is bigger.");
            }
            else if (average2 > average1)
            {
                Console.WriteLine("Average of the second array is bigger.");
            }
            else { Console.WriteLine("Averages are equal."); }

        }
    }
}