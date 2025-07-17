public class SortCategory
{
    private string _name;
    public SortCategory(string name)
    {
        _name = name;
    }
    public string Getname()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
    }
}