namespace GeometricAreaLibrary.Figure;

public class Triangle: GeometricLibrary
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly double _radius;

    public Triangle(double a, double b, double c, double radius)
    {
        _a = a;
        _b = b;
        _c = c;
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(_a * _b * _c / (4 * _radius), 1);
    }
}