using System.ComponentModel;

public class Budget
{
    private SortCategory _category;
    private int _limit;
    private int _currentSpendings;
    public Budget(SortCategory category, int limit, int currentSpendings)
    {
        _category = category;
        _limit = limit;
        _currentSpendings = currentSpendings;

    }
    public void AddExpense()
    {

    }
    public bool IsOverBudget()// did i make too much damage??
    {
        if (_currentSpendings >= _limit)//make if statement here to define next moves
        {
            Console.WriteLine("Mo'For stop doing so much damage! Get a hold of yo self.");
            Console.ReadLine();
        }
        else if()
    }
    public int GetRemainingMoney()
    {

    }
}