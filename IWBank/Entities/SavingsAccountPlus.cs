namespace IWBank.Entities;

public class SavingsAccountPlus : SavingAccount
{
    public SavingsAccountPlus(int number, string holder, double balance, double interestRate) : base(number, holder, balance, interestRate)
    {
    }
}
