namespace HomeWork
{
    static class FourthExercise
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number a: ");
            var a = Console.ReadLine();

            Console.Write("Method 1 - > ");
            if (Convert.ToDouble(a) % 2 == 0)
            {
                Console.WriteLine("Number a is even.");
            }
            else
            {
                Console.WriteLine("Number a is not even.");
            }

            Console.Write("Method 2 - > ");
            a = (a.Substring(a.Length - 1));
            if (a == "0" || a == "2" || a == "4" || a == "6" || a == "8")
            {
                Console.WriteLine("Number a is even.");
            }
            else
            {
                Console.WriteLine("Number a is not even.");
            }
        }
    }
}