using System;

class Program
{
    static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Billy", 37);
        Doctor myDoctor = new Doctor("Doc.Bob", "Billy", 37, "Hack saw",450000);
        Police myPoliceMan = new Police("Officer Bob", "Billy", 37, "Rocket Launcher", 56, 87);
        //Console.WriteLine(myPerson.GetPersonInfo());
        //Console.WriteLine(myDoctor.GetDoctorsInfo());
       // Console.WriteLine(myPoliceMan.GetPersonInfo());
        //Console.WriteLine(policemanBob.GetPoliceInfo());
        

        List<Person> myPeople = new List<Person>();
        //myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach(Person person in myPeople)
        {
            DisplayPersonInfo(person);
        }
    }
    private static void DisplayPersonInfo(Person person)
    {
        Console.WriteLine(person.GetPersonInfo());// this one line will go through perso,doc and policeman and give what it gives
        Console.WriteLine($"Salary: {person.GetSalary}");
    }
}