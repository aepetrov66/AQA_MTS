namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class FifthExercise
    {
        static void MainMain(string[] args)
        {

            int size;

            while (true)
            {
                Console.Write("Enter the array size: ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 5 && size <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input data. Size must be in range (5; 10]");
                    continue;
                }
            }

            int[] array1 = new int[size];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(100);
            }

            Console.Write("First array\t{ ");
            foreach (int i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("}");

            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("There are no even numbers in first array.");
            }
            else
            {

                int[] array2 = new int[counter];
                counter = 0;

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 == 0)
                    {
                        array2[counter] = array1[i];
                        counter++;
                    }
                }

                Console.Write("Second array\t{ ");
                foreach (int i in array2)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("}");
            }
        }
    }
}
