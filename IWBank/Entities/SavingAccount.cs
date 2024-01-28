namespace IWBank.Entities;

public class SavingAccount : Account //classes sealed nao podem ser extendidas a sub classes
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

    //sobreposicao na sub classe
    // metodos sealed nao podem ser sobrescritos novamente
    public override sealed void Withdraw(double amount)
    {
       Balance -= amount;
    }
}
