namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class EighthExercise
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
            Console.Write("Before: ");
            foreach (int s in array)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }
                }
            }
            Console.Write("After: ");
            foreach (int s in array)
            {
                Console.Write($"{s} ");
            }


        }
    }
}