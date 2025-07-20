class Program
{
    static void Main(string[] args)
    {
        BudgetManager budgetManager = new BudgetManager();
        CategoryManager categoryManager = new CategoryManager();
        ReportGenerator reportGenerator = new ReportGenerator();
        bool running = true;

        // Predefined categories
        categoryManager.AddCategory("Food");
        categoryManager.AddCategory("Rent");
        categoryManager.AddCategory("Utilities");
        categoryManager.AddCategory("Salary");
        categoryManager.AddCategory("Other");

        Console.WriteLine("Welcome to Budget Tracker!");

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Balance");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. View Spending Report by Category");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTransaction(budgetManager, categoryManager, isIncome: true);
                    break;
                case "2":
                    AddTransaction(budgetManager, categoryManager, isIncome: false);
                    break;
                case "3":
                    Console.WriteLine($"Current Balance: ${budgetManager.GetBalance()}");
                    break;
                case "4":
                    budgetManager.PrintHistory();
                    break;
                case "5":
                    reportGenerator.GenerateSpendingByCategory(budgetManager.GetTransactions());
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void AddTransaction(BudgetManager manager, CategoryManager categoryManager, bool isIncome)
    {
        Console.Write("Enter amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        categoryManager.DisplayCategories();
        Console.Write("Enter category: ");
        string category = Console.ReadLine();

        if (!categoryManager.IsValidCategory(category))
        {
            Console.WriteLine("Invalid category. Try again.");
            return;
        }

        Transaction transaction = isIncome
            ? new Income(amount, description, category)
            : new Expense(amount, description, category);

        manager.AddTransaction(transaction);

        Console.WriteLine($"{(isIncome ? "Income" : "Expense")} added successfully.");
    }
}