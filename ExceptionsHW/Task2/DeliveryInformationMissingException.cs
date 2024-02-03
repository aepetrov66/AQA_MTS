namespace Task2;

class DeliveryInformationMissingException : Exception
{
    public DeliveryInformationMissingException() { }
    public DeliveryInformationMissingException(string message) : base(message) { }
}

