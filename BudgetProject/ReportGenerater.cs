public class ReportGenerator
{
    private List<Damage> _damages;

    public ReportGenerator(List<Damage> damages)
    {
        _damages = damages;
    }

    public void GenerateSpendingByCategory()
    {
        Dictionary<string, decimal> totals = new Dictionary<string, decimal>();

        foreach (var d in _damages)
        {
            if (d is Expense exp)
            {
                if (totals.ContainsKey(exp.Category))
                    totals[exp.Category] += exp.Amount;
                else
                    totals[exp.Category] = exp.Amount;
            }
        }

        Console.WriteLine("\nDamage Report by Category:");
        foreach (var entry in totals)
        {
            Console.WriteLine($"{entry.Key}: ${entry.Value}");
        }
    }
}
