class Program
{
    static void Main(string[] args)
    {
        BudgetManager budgetManager = new BudgetManager();
        CategoryManager categoryManager = new CategoryManager();
        ReportGenerator reportGenerator = new ReportGenerator();
        bool running = true;

        
        categoryManager.AddCategory("Food");
        categoryManager.AddCategory("Rent");
        categoryManager.AddCategory("Utilities");
        categoryManager.AddCategory("Salary");
        categoryManager.AddCategory("Other");

        Console.WriteLine("Welcome to my Damage Tracker aka budget helper!");

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Moneys");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Balance(how much more damage you can do)");
            Console.WriteLine("4. View History(ultimate damage done)");
            Console.WriteLine("5. View Spending Report by Category(previous damage)");
            Console.WriteLine("6. Get out of here");
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
                    Console.WriteLine("Bruh.. Try again.");
                    break;
            }
        }

        Console.WriteLine("adios amigo");
    }

    static void AddTransaction(BudgetManager manager, CategoryManager categoryManager, bool isIncome)
    {
        Console.Write("Gimme an amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Gimme a description: ");
        string description = Console.ReadLine();

        categoryManager.DisplayCategories();
        Console.Write("how bout gimme a category: ");
        string category = Console.ReadLine();

        if (!categoryManager.IsValidCategory(category))
        {
            Console.WriteLine("Invalid category. wtheck, lets do this again bro.");
            return;
        }

        Transaction transaction = isIncome
            ? new Income(amount, description, category)
            : new Expense(amount, description, category);

        manager.AddTransaction(transaction);

        Console.WriteLine($"{(isIncome ? "Income" : "Expense")} heck yeah! its been added!");
    }
}