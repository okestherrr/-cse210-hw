class Program
{
    static double AddNumbers(double a, int b) //when using permaters you have to include the data inside as well
    {
        return a + b;  
    }
    static void Displaygreeting()
    {
        Console.WriteLine("Hello bob");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");     
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        Console.Write($"Your name is {lastName}, {firstName}.");

                // using System;
        //using System.Data;
        //using System.Numerics;

        //class Program
    
        //Console.WriteLine("Hello Learning03 World!");

        // int x = 0;
        // int y = x++; // this make y 1
        // Console.WriteLine(y);
        // y = ++x; // this make y 2
        //Console.WriteLine(x);

        // || Or && AddingNewEventArgs ! not

        // random randomGenerator = new Random();
        // int randomNumber = new randomGenerator(1,100);

        List <int> myNumbers = new List<int>();
        myNumbers.Add(99);
        myNumbers.Add(10);
        myNumbers.Add(-123);
        // myNumbers.

        // Console.WriteLine("");

        foreach (int i in myNumbers)
        {
           // Console.WriteLine(i);
            // total += i;
           //  Console.WriteLine(total);

            double total = AddNumbers(123.4567, 987);
            Console.WriteLine(total);
            Console.WriteLine(AddNumbers(234,432));

            Displaygreeting();

            bool done = false; 
            while(!done) // here is using while loop
            {
                done = true;
            }

            do{
                Console.WriteLine("");
            }
            while(!done);
        }
    }
}


