using System;
using System.Diagnostics.Tracing;

class Program 
{
    static void Main(string[] args)
    { // cicle is the class my circle is the object
        Circle myCircle = new Circle();
        Circle myCircle2 = new Circle();
        myCircle.SetRadius(10);
        //myCircle._radius = 10;
        Console.WriteLine($"{myCircle.GetRadius()}");

        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetCircle(myCircle);
        myCylinder.SetHeight(10);
        Console.WriteLine($"{myCylinder.GetVolume()}");


    }
}