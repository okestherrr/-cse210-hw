public class Goal
{
    private string _name;
    private decimal _targetAmount;
    private decimal _currentAmount;

    public Goal(string name, decimal targetAmount)
    {
        _name = name;
        _targetAmount = targetAmount;
        _currentAmount = 0;
    }

    public void AddToGoal(decimal amount)
    {
        _currentAmount += amount;
    }

    public bool IsGoalReached() => _currentAmount >= _targetAmount;

    public decimal GetRemainingAmount() => _targetAmount - _currentAmount;
}
