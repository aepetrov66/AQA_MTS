namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class SecondExercise
    {
        static void MainMain(string[] args)
        {
            int[] array = { 1, 1, 1, 2, 2, 2, 22, 44, 44, 4, 17, 52, 11, 14, 15, 22, 1, 1 };

            Console.Write("Enter number to search in array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            //подсчет количества вхождений удаляемого символа
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] == num)
                {
                    counter++;
                }
            }


            int[] newArray = new int[array.Length - counter];
            counter = 0;

            //запись в новый массив чисел за исключением удаляемого символа
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] != num)
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }

            array = newArray;

            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}