public abstract class Transaction
{
    protected decimal _amount;
    protected DateTime _date;
    protected string _description;

    public Transaction(decimal amount, DateTime date, string description)
    {
        _amount = amount;
        _date = date;
        _description = description;
    }

    public abstract void ApplyToBalance(Program user);
}
