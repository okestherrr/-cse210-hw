public class Expense : Damage
{
    public string Category;

    public Expense(decimal amount, DateTime date, string description, string category)
        : base(amount, date, description)
    {
        Category = category;
    }

    public override void ApplyToBalance(Budget budget)
    {
        budget.Balance -= Amount;
    }
}