namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class FirstExercise
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 15, 48, 29, 44, 66, 92, 68, 3, 4, 17, 52, 11, 14, 15, 22, 104, 7 };

            Console.Write("Enter number to search in array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool flag = false;

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"{num} is included in array with index {i}.");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{num} is not included.");
            }
        }
    }
}
