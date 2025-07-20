public class ReportGenerator
{
    public string GenerateTransactionReport(List<Transaction> transactions)
    {
        return $"Total Transactions: {transactions.Count}";
    }

    public string GenerateBudgetReport(List<Budget> budgets)
    {
        return $"Budgets: {budgets.Count}";
    }

    public string GenerateGoalProgress(List<Goal> goals)
    {
        return $"Goals Tracked: {goals.Count}";
    }
}