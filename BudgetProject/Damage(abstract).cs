using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

//transactions aka damage
public abstract class Damage
{
    public decimal Amount;
    public DateTime Date;
    public string Description;

    public Damage(decimal amount, DateTime date, string description)
    {
        Amount = amount;
        Date = date;
        Description = description;
    }

    public abstract void ApplyToBalance(Budget budget);
}