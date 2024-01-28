namespace Task2
{
    public class Set : Product
    {
        public int amount;

        public Set(string name, double price, DateTime productionDate, int shelfLifeInDays, int amount) : base(name, price, productionDate, shelfLifeInDays)
        {
            this.amount = amount;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine($"Количество: {this.amount}");
        }

        public override bool IsProductAllive()
        {
            return base.IsProductAllive();
        }
    }
}
