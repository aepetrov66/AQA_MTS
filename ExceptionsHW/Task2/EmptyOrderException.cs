namespace Task2;

class EmptyOrderException : Exception
{
    public EmptyOrderException() { }
    public EmptyOrderException(string message) : base(message) { }
}

