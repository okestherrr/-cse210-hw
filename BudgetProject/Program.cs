class Program
{
    static void Main(string[] args)
    {
          Budget budget = new Budget();
        SortCategory categories = new SortCategory();

       categories.AddCategory("Food");
        categories.AddCategory("Rent");
        categories.AddCategory("Utilities");
        categories.AddCategory("Entertainment");
        categories.AddCategory("Other");

        Console.WriteLine("Welcome to my Damage Tracker aka budget helper!");
        bool running = true;
        while (running)
        { Console.WriteLine("\nPick from the Menu:");
            Console.WriteLine("1 - Add Moneys");
            Console.WriteLine("2 - Add Expense");
            Console.WriteLine("3 - Show Balance");
            Console.WriteLine("4 - Show Damage Report");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose one please: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIncome(budget);
                    break;
                case "2":
                    AddExpense(budget, categories);
                    break;
                case "3":
                    Console.WriteLine($"Balance: ${budget.Balance}");
                    break;
                case "4":
                    var report = new ReportGenerator(budget.Damages);
                    report.GenerateSpendingByCategory();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        Console.WriteLine("Adios Amigo");
    }

    private static void AddIncome(Budget budget)
    {
        Console.Write("Gimme an amount: ");
         if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Fake news, gimme an actual amount.");
            return;
        }

        Console.Write("Gimme a Description: ");
        string description = Console.ReadLine();

         ShowSpinner();

        budget.AddDamage(new Income(amount, DateTime.Now, description));
        Console.WriteLine("Income has been added.");
    }

    private static void AddExpense(Budget budget, SortCategory categories)
    {
        Console.Write("Gimme an amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        Console.Write("gimme a description: ");
        string description = Console.ReadLine();

        categories.ShowCategories();
        Console.Write("gimme a category for that: ");
        string category = Console.ReadLine();

        Console.Clear();

        if (!categories.IsValid(category))
        {
            Console.WriteLine("bruh that category isnt available.");
            return;
        }

        ShowSpinner();

        budget.AddDamage(new Expense(amount, DateTime.Now, description, category));
        Console.WriteLine("Expense added!");
    }

    private static void ShowSpinner()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.WriteLine();
        }
    }
}