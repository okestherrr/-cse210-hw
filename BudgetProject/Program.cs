using System;

public class Program
{
    private string _name;
    private int _balance;
    private List<Transaction> _transaction;

    private List<Goals> _goals;
    public Program(string name, int balance)
    {
        _name = name;
        _balance = balance;
    }
    public void AddTransaction()
    {
        return;
    }
    public void Addbudget()
    {
        return;
    }
    public void AddGoal(Budget budget)
    {

    }
    public int Getbalance()// fix this by adding to balance and getting info
    {
        Console.Write("what is the your balance? ");
        int balance = int.Parse(Console.ReadLine());
    }
    public void UpdateTheBalance()
    {
        _balance.Add(Getbalance);
    }
}
