namespace IWBank.Entities;

public class SavingAccount : Account
{
    public double InterestRate { get; private set; }

    public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }
}
