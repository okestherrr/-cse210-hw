public class Budget
{
    private SortCategory _category;
    private decimal _limit;
    private decimal _currentSpending;

    public Budget(SortCategory category, decimal limit)
    {
        _category = category;
        _limit = limit;
        _currentSpending = 0;
    }

    public void AddExpense(decimal amount)
    {
        _currentSpending += amount;
    }

    public bool IsOverBudget() => _currentSpending > _limit;

    public decimal GetRemainingBudget() => _limit - _currentSpending;
}