namespace ClassesHW
{
    public class Phone
    {
        public string number;
        public string model;
        public double weight;

        public Phone() { }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }

        public void receiveCall(string name)
        {
            Console.WriteLine("Звонит {0}", name);
        }

        public string getNumber()
        {
            return number;
        }

        public void SendMessage(params string[] numbers)
        {
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
