namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class ThirdExercise
    {
        static void MainMain(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("}");

            Array.Sort(array);
            Console.WriteLine($"Max: {array[array.GetUpperBound(0)]}");
            Console.WriteLine($"Min: {array[array.GetLowerBound(0)]}");

            if (array.Length%2 == 0)
            {
                Console.WriteLine($"Avr: {array[array.GetUpperBound(0)/2]}");
            }
            else {Console.WriteLine($"Avr: {array[array.GetLength(0)/2]} or {array[array.GetLength(0) / 2 - 1]}"); }
        }
    }
}