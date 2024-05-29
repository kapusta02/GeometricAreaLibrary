namespace GeometricAreaLibrary.Figure;

public class Circle : GeometricLibrary
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 1);
    }
}