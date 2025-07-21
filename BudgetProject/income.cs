public class Income : Damage
{
    public Income(decimal amount, DateTime date, string description)
        : base(amount, date, description)
    {
            
    }

    public override void ApplyToBalance(Budget budget)
    {
        budget.Balance += Amount;
    }
}