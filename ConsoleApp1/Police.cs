class Police : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;

    public Police(string firstName, string lastName, int age, string weapons, int hoursworked, double hours) : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hourlyWage = hours;
        _hoursWorked = hoursworked;

    }
    // ask alex bout this
    public string GetPoliceInfo()
    {
        return $"{_weapons}, {GetPersonInfo()}";
    }
    public override string GetPersonInfo()
    {
        return $" Weapons: {_weapons} :: {base.GetPersonInfo()}";
    }
    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
       
    }

}