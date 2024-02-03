namespace Task2;

class InvalidOrderNumberException : Exception
{
    public InvalidOrderNumberException() { }
    public InvalidOrderNumberException(string message) : base(message) { }
}

