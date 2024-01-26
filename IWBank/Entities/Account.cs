namespace IWBank.Entities;

public class Account
{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }


    public Account(int number, string holder, double balance)
    {
        Deposit(balance);
        Holder = holder;
        Number = number;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
