class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstName, string lastName, int age, string tools, double salary) : base(firstName, lastName, age)
    {
        _tools = tools;
        _salary = salary;
    }
    public string GetDoctorsInfo()
    {
        return $"{_tools}, {GetPersonInfo()}";
    }
    public override string GetPersonInfo()
    {
        return $" Tools: {_tools} :: {base.GetPersonInfo()}";
    }
    public override double GetSalary()
    {
        return _salary;
    }
}