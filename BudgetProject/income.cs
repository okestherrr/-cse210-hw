public class Income : Transaction
{
    public Income(decimal amount, DateTime date, string description)
        : base(amount, date, description) { }

    public override void ApplyToBalance(Program user)
    {
        user.UpdateBalance(_amount);
    }
}