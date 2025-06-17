abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;

    }
    public virtual string GetPersonInfo()//base classs must use default stuff
    {
        return $"{_firstName}, {_lastName}, Age: {_age}";
    }
    public abstract double GetSalary();// base class CAN NOT provide default and the child class must make the changes
   
}