namespace HomeWork // Note: actual namespace depends on the project name.
{
    static class FirsExcercise
    {
        static void MainMain(string[] args)
        {
            Console.Write("Enter the number a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the mathematic operator: ");
            var symbol = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Enter the number b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            switch (symbol.KeyChar)
            {
                case '+':
                    Console.WriteLine($"a + b = {a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"a - b = {a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"a * b = {a} * {b} = {a * b}");
                    break;
                case '/':
                    if (b != 0)
                    {
                        Console.WriteLine($"a / b = {a} / {b} = {a / b}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by zero.");
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect input data ):");
                    break;
            }


        }
    }
}
