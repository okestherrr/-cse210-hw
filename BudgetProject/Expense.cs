using System;

public class Expense : Transaction
{
    private SortCategory _category;
    public Expense(SortCategory category)
    {
        _category = category;
    }
    public override void ApplyItToBalance(Program program)
    {

    }
    public string GetCategory()// find out why this is not working
    {

    }
}