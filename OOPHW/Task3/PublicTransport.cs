using Task;

namespace Task3;

public abstract class PublicTransport : Transport
{
    public string destination { get; set; }
    public int number { get; set; }
    public DateTime departureTime { get; set; }
    public int passengers { get; set; }
}
