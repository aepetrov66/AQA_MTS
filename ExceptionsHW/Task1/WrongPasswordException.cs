namespace Task1;

class WrongPasswordException : Exception
{
    public WrongPasswordException() { }
    public WrongPasswordException(string message) : base(message) { }
}
