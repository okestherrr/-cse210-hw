class Circle //class
{
    private double _radius; //

    public Circle()
    {
        _radius = 0.0;
    }

    public Circle(double radius)
    {
        // _radius = radius;
        SetRadius(radius);
    }

    public void SetRadius(double radius) // A public method lets u use it throughout different classes, private is used only in the same class its in. 
    {
        if (radius < 0)
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



