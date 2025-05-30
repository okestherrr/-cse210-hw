using System;
using System.Diagnostics.Tracing;

class Program 
{
    static void Main(string[] args)
    { // cicle is the class my circle is the object
        Circle myCircle = new Circle(10);
        // Circle myCircle2 = new Circle();
        // myCircle.SetRadius(10);
        //myCircle._radius = 10;
        Console.WriteLine($"{myCircle.GetArea()}");

        // myCircle2.SetRadius(20);
        // Console.WriteLine($"{myCircle2.GetRadius()}");

        // Console.WriteLine($"{myCircle.GetArea()}");
        // Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder(100,5);
        // myCylinder.SetCircle(myCircle);
        // myCylinder.SetHeight(10);
        Console.WriteLine($"{myCylinder.GetVolume()}");


    }
}