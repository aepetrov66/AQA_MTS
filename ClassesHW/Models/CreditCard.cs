using System.Text;

namespace ClassesHW
{
    public class CreditCard
    {
        public long personalAccount;
        public double amount;

        public CreditCard(long personalAccount, double amount)
        {
            this.personalAccount = personalAccount;
            this.amount = amount;
        }

        public void AddMoney(double money)
        {
            this.amount += money;
        }
        public void TakeMoney(double money)
        {
            this.amount -= money;
        }
        public void Info()
        {
            Console.OutputEncoding = Encoding.GetEncoding("utf-8");
            Console.WriteLine(string.Format("{0:#### #### #### ####}",this.personalAccount));
            Console.WriteLine(string.Format("{0:C}", this.amount));
        }
    }
}
