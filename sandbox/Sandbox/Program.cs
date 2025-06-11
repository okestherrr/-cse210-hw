using System;


class Program
{
    private static void Main(string[] args)
    {


        // { // cicle is the class my circle is the object
        //     Circle myCircle = new Circle(10);
        //     // Circle myCircle2 = new Circle();
        //     // myCircle.SetRadius(10);
        //     //myCircle._radius = 10;
        //     Console.WriteLine($"{myCircle.GetArea()}");

        //     // myCircle2.SetRadius(20);
        //     // Console.WriteLine($"{myCircle2.GetRadius()}");

        //     // Console.WriteLine($"{myCircle.GetArea()}");
        //     // Console.WriteLine($"{myCircle2.GetArea()}");

        //     Cylinder myCylinder = new Cylinder(100,5);
        //     // myCylinder.SetCircle(myCircle);
        //     // myCylinder.SetHeight(10);
        //     Console.WriteLine($"{myCylinder.GetVolume()}");
        int sleepTime = 250;
        int time = 9;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);
        string animationString2 = "-+\\/-$*";
        int index = 0;

        while (DateTime.Now < endTime)

        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

        int count = time;

        while (DateTime.Now < endTime)

        {
            Console.Write(count - -); // shows 1 first ,//(- - count ) shows 8 first 
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        string animationString = "(^-^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            // Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[0..5]);
            // Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

        }
    }
}