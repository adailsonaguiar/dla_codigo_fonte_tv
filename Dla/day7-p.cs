public class Account
{
    private double accountBalance;
    double limit = 0;

    public Account(double balance)
    {
        accountBalance = balance;
    }

    public double getBalance()
    {
        double limitAccount = limit / 100;

        if (this.accountBalance + limitAccount == 0)
        {
            Console.WriteLine("Account without balance...");
        }

        if (limitAccount > 0)
        {
            Console.WriteLine("Using account limit...");
        }

        return accountBalance;
    }

    public void makeDeposit(double amount)
    {
        accountBalance += amount;
    }

    public void makeWithdrawal(double amount)
    {
        double limitAccount = limit / 100;

        if (accountBalance + limitAccount > 0)
        {
            Console.WriteLine("Account out of limit...");
            return;
        }
        accountBalance -= amount;
    }
}

public class Bank
{
    private Account account1;
    private Account account2;

    public Bank(Account account1, Account account2)
    {
        this.account1 = account1;
        this.account2 = account2;
    }

    public void transfer(Account from, Account to, double amount)
    {
        from.makeWithdrawal(amount);
        to.makeDeposit(amount);
    }

}