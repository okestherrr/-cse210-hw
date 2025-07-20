public class ReportGenerator
{
    public void GenerateSpendingByCategory(List<Transaction> transactions)
    {
        var grouped = transactions
            .Where(t => t is Expense)
            .GroupBy(t => t.Category)
            .Select(g => new { Category = g.Key, Total = g.Sum(t => t.Amount) });

        Console.WriteLine("\nExpense Report by Category:");
        foreach (var item in grouped)
        {
            Console.WriteLine($"{item.Category}: ${item.Total}");
        }
    }
}