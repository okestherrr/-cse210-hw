public abstract class Transaction
{
    private int _amount;
    private DateTime _date;
    private string _description;

    public Transaction(int amount, DateTime date, string desciption)
    {
        _amount = amount;
        _date = date;
        _description = desciption;
    }
    public abstract void ApplyItToBalance(Program program);
}