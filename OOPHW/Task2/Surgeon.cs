using Task2;

namespace Task2
{
    public class Surgeon : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Операция.");
        }
    }
}