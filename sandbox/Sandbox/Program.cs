using System;
using System.Diagnostics.Tracing;

class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
       if(radius < 0)
       {
        Console.WriteLine("Error");
        return;
       }
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    } 

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    
}
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

    }
}


