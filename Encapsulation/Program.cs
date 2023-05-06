
class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);

        myAccount.Deposit(500);
        Console.WriteLine("Balance: " + myAccount.GetBalance());

        myAccount.Withdraw(1200);
        Console.WriteLine("Balance: " + myAccount.GetBalance());
    }
}
