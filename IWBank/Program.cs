using IWBank.Entities;

namespace IWBank;

internal class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 100);
        SavingAccount savingAccount = new SavingAccount(20, "jose", 100, 200);
        acc.Withdraw(10);
        savingAccount.Withdraw(10);
        Console.WriteLine(acc.Balance);
        Console.WriteLine(savingAccount.Balance);
        // BusinessAccount bcc = new BusinessAccount(200, "Isa", 0, 500);
        //
        // //upcasting
        // Account upAcc = bcc;
    }
}
