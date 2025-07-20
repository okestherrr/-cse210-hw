public class Expense : Transaction
{
    private Category _category;

    public Expense(decimal amount, DateTime date, string description, Category category)
        : base(amount, date, description)
    {
        _category = category;
    }

    public override void ApplyToBalance(User user)
    {
        user.UpdateBalance(-_amount);
    }

    public Category GetCategory() => _category;
}