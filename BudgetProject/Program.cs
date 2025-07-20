public class User
{
    private string _name;
    private decimal _balance;
    private List<Transaction> _transactions = new List<Transaction>();
    private List<Budget> _budgets = new List<Budget>();
    private List<Goal> _goals = new List<Goal>();

    public User(string name, decimal initialBalance)
    {
        _name = name;
        _balance = initialBalance;
    }

    public void AddTransaction(Transaction transaction)
    {
        transaction.ApplyToBalance(this);
        _transactions.Add(transaction);
    }

    public void AddBudget(Budget budget) => _budgets.Add(budget);

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public decimal GetBalance() => _balance;

    public void UpdateBalance(decimal amount)
    {
        _balance += amount;
    }
}