namespace HomeWork
{
    static class SecondExercise
    {
        static void MainMain(string[] args)
        {
            Console.Write("Enter number ranging from -50 to 50 - > ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num < -50 || num > 50)
            {
                Console.WriteLine("Incorrect number. Read instructions.");
            }
            else if (num >= -40 && num <= -10)
            {
                Console.WriteLine("Number included in the range [-40; -10].");
            }
            else if (num >= -9 && num <= 0)
            {
                Console.WriteLine("Number included in the range [-9; 0].");
            }
            else if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Number included in the range [1; 10].");
            }
            else if (num >= 11 && num <= 40)
            {
                Console.WriteLine("Number included in the range [11; 40].");
            }
            else
            {
                Console.WriteLine("Number is not included in any range.");
            }

        }
    }
}
