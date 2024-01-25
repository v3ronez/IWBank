namespace IWBank.Entities;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    private double Balance { get; set; }


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
