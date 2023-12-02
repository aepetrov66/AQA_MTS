namespace HomeWork2 // Note: actual namespace depends on the project name.
{
    static class SeventhExercise
    {
        static void MainMain(string[] args)
        {
            string[] array = new string[] { "Barbara", "Andrew", "Tom", "James", "Scott" };
            Console.Write("Before: ");
            foreach (string s in array)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (IsBigger(array[j], array[j + 1]))
                    {
                        string buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }
                }
            }


            Console.Write("After: ");
            foreach (string s in array)
            {
                Console.Write($"{s} ");
            }

        }
        static bool IsBigger(string name1, string name2)
        {
            int counter;
            if (name1.Length >= name2.Length)
            {
                counter = name2.Length;
            }
            else { counter = name1.Length; }

            for (int x = 0; x < counter; x++)
            {
                if (Convert.ToInt32(name1[x]) > Convert.ToInt32(name2[x]))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
    }
}