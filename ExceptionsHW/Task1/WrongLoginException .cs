namespace Task1;

class WrongLoginException : Exception
{
    public WrongLoginException() { }
    public WrongLoginException(string message) : base(message) { }
}

