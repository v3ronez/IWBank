namespace IWBank.Entities;

public class BusinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinessAccount(int number, string holder, double balance, double loanLimits) : base(number, holder, balance)
    {
        LoanLimit = loanLimits;
    }
}
