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

    //key 'virtual' permite que sub classes façam a sobreposicao do metodo da classe acima
    public virtual void Withdraw(double amount)
    {
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
