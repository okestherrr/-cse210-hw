public class BudgetManager
{
    private decimal _balance = 0;
    private List<Transaction> _transactions = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        transaction.Apply(this);
        _transactions.Add(transaction);
    }

    public void AddToBalance(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public List<Transaction> GetTransactions()
    {
        return _transactions;
    }

    public void PrintHistory()
    {
        Console.WriteLine("\nTransaction History:");
        foreach (var t in _transactions)
        {
            Console.WriteLine(t.GetInfo());
        }
    }
}