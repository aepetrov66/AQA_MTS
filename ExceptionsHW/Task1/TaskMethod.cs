using System.Text.RegularExpressions;

namespace Task1;

internal class TaskMethod
{
    public static bool TakeThree(string login, string password, string confirmPassword)
    {
        if (login.Length > 20 || login.Contains(" "))
        {
            throw new ArgumentException("Wrong login.");

        }
        else if (password.Length > 20 || password.Contains(" ") || !Regex.IsMatch(password, @"\d", RegexOptions.IgnoreCase) || !password.Equals(confirmPassword))
        {
            throw new WrongPasswordException("Wrong password.");
        }
        else
        {
            return true;
        }
    }
}
