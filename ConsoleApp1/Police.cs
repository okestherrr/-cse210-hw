class Police : Person 
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, string weapons) : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }
    // ask alex bout this
    public string GetPoliceInfo()
    {
        return $"{_weapons}, {GetPersonInfo()}";
    }
}