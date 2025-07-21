public class SortCategory
{
    private List<string> _categories = new List<string>();

    public void AddCategory(string category)
    {
        _categories.Add(category);
    }

    public void ShowCategories()
    {
        Console.WriteLine("Categories:");
        foreach (string category in _categories)
        {
            Console.WriteLine(category);
        }
    }

    public bool IsValid(string category)
    {
        return _categories.Contains(category);
    }
}
