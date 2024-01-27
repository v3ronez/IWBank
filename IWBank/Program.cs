using IWBank.Entities;

namespace IWBank;

internal class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0);
        BusinessAccount bcc = new BusinessAccount(200, "Isa", 0, 500);

        //upcasting
        Account upAcc = bcc;

    }
}
