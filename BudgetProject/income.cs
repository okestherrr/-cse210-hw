public class Income : Transaction
{
    public Income(decimal amount, string description, string category) : base(amount, description, category) { }

    public override void Apply(BudgetManager manager)
    {
        manager.AddToBalance(_amount);
    }

    public override string GetInfo()
    {
        return $"{_date.ToShortDateString()} | INCOME  | +${_amount} | {_description} [{_category}]";
    }
}