public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Console.WriteLine("Depositing {0}", amount);
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Console.WriteLine("Withdrawing {0}", amount);
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public decimal GetBalance() { return balance; }
}