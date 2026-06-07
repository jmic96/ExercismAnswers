static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        while (balance < 0)
        {
            return 3.213f;
        }
        while (0 <= balance && balance < 1000)
        {
            return 0.5f;
        }
        while (1000 <= balance && balance < 5000)
        {
            return 1.621f;
        }
        while (5000 <= balance)
        {
            return 2.475f;
        }
        return 0f;
    }

    public static decimal Interest(decimal balance)
    {
        return ((decimal)InterestRate(balance) * balance)/100;
    }


    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (decimal)Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
