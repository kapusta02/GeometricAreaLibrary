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
        if (radius == 0)
            throw new ArgumentException("Radius must be greater than zero");
    }

    public override double CalculateArea()
    {
        return Math.Round(_a * _b * _c / (4 * _radius), 1);
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { _a, _b, _c };
        Array.Sort(sides);

        return AreClose(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2),Math.Pow(sides[2], 2));
    }
    
    private bool AreClose(double d1, double d2, double delta = 1e-9)
    {
        return Math.Abs(d1 - d2) < delta;
    }
}