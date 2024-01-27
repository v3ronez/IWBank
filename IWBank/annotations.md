# Upcasting

Nada mais é do que tipar uma variavel como uma supe classe mas atribuir a ela uma sub-classe.

### Exemplo:

Esse exemplo temos uma superclasse do chamada _Account_. A partir dela sera criada uma classe chamada _BusinessAccount_.

```c#
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
```

```c#
namespace IWBank.Entities;

public class BusinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinessAccount(int number, string holder, double balance, double loanLimits) : base(number, holder, balance)
    {
        LoanLimit = loanLimits;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit)
        {
            Deposit(LoanLimit);
        }
    }
}
```

Por ser uma sub-classe de _Account_ é posívelmente normal e aceitável o código abaixo.

```c#
        Account acc = new Account(1001, "Alex", 0);
        BusinessAccount bcc = new BusinessAccount(200, "Isa", 0, 500);

        Account upAcc = bcc;
```

Nesse cenário está acontecendo o *UpCasting*. O *UpCasting* a grosso modo é a conversão da sub-classe para a superclase.

Porém quando fazemos o upcasting de uma sub-classe, o compilador da erro
is => checar se uma variavel é do tipo inferico
as => fazer upcasting ou downcasting com outra syntax

```c#
  Account acc = new Account(1001, "Alex", 0);
  BusinessAccount bcc = acc as Account;

  if(acc is Account) {
    //do something      
  }
```
