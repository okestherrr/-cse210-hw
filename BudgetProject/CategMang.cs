public class CategoryManager
{
    private List<Category> _categories = new List<Category>();

    public void AddCategory(string name)
    {
        _categories.Add(new Category(name));
    }

    public bool IsValidCategory(string name)
    {
        return _categories.Any(c => c.Name.ToLower() == name.ToLower());
    }

    public void DisplayCategories()
    {
        Console.WriteLine("Categories to pick from:");
        foreach (var cat in _categories)
        {
            Console.WriteLine($"- {cat.Name}");
        }
    }
}