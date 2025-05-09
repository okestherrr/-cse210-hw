class Cylinder
// private keep the info secure
{
    
    private Circle _circle;
    private double _height;
    public void SetHeight(double height)
    {
        height = _height;
    }
    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }
    public double GetVolume()
    {
        double radius =_circle.GetRadius();
        return Math.PI * radius * radius * _height;
    }
    
}