
namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myaccount = new BankAccount(0);
            Console.WriteLine("How much do you want to deposit");
            double amounttodeposit = double.Parse(Console.ReadLine());
            myaccount.deposit(amounttodeposit);

            double userbalance = myaccount.getbalance();
            Console.WriteLine($"You have {userbalance} as your balance");
        }
    }
}
