using System;
using System.Collections.Generic;
using System.Linq;

// 1. Base class
public abstract class Transaction
{
    protected decimal _amount;
    protected DateTime _date;
    protected string _description;
    protected string _category;

    public Transaction(decimal amount, string description, string category)
    {
        _amount = amount;
        _date = DateTime.Now;
        _description = description;
        _category = category;
    }

    public DateTime Date => _date;
    public string Description => _description;
    public string Category => _category;
    public decimal Amount => _amount;

    public abstract void Apply(BudgetManager manager);
    public abstract string GetInfo();
}