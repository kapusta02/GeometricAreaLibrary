namespace GeometricAreaLibrary;

public class GeometricLibrary
{
    public double CircleArea(double radius)
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 1);
    }
    
    public double TriangleArea(double a, double b, double c, double radius)
    {
        return Math.Round(a * b * c / (4 * radius), 1);
    }
}