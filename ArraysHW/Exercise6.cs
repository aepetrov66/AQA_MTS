namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class SixthExercise
    {
        static void MainMain(string[] args)
        {

            int size;

            Console.Write("Enter the array size: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100);
            }

            Console.Write("Array:\t{ ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"a[{i}] = {array[i]};\t");
            }
            Console.WriteLine("}");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    array[i] = 0;
                }
            }

            Console.Write("Array:\t{ ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"a[{i}] = {array[i]};\t");
            }
            Console.WriteLine("}");

        }
    }
}
