class Police : Person // alex( is this connecting each case), is there a time when you wouldnt do this or there would be mulitple that you could clash together
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