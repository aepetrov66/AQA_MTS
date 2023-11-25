namespace HomeWork
{
    static class ThirdExercise
    {
        static void MainMain(string[] args)
        {
            Console.Write("Enter the word to translate:\n - Какая сегодня погода?\n - ");
            string word = Console.ReadLine();

            Console.Write("Translated: The weather is ");

            switch (word.ToLower())
            {
                case "ненастная":
                    Console.WriteLine("nasty");
                    break;
                case "солнечная":
                    Console.WriteLine("sunny");
                    break;
                case "облачная":
                    Console.WriteLine("cloudy");
                    break;
                case "дождливая":
                    Console.WriteLine("rainy");
                    break;
                case "ветренная":
                    Console.WriteLine("windy");
                    break;
                case "туманная":
                    Console.WriteLine("foggy");
                    break;
                case "холодная":
                    Console.WriteLine("cold");
                    break;
                case "теплая":
                    Console.WriteLine("warm");
                    break;
                case "прохладная":
                    Console.WriteLine("chilly");
                    break;
                case "морозная":
                    Console.WriteLine("frosty");
                    break;
                default:
                    Console.WriteLine("I don't know this word.");
                    break;
            }
        }
    }
}