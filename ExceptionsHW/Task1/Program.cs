namespace Task1;

public class Program
{

    public static void Main()
    {
        for (int i = 0; i < 3; i++)
        {

            try
            {
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                string confirmPassword = Console.ReadLine();
                TaskMethod.TakeThree(login, password, confirmPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}