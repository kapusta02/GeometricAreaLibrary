using GeometricAreaLibrary.Figure;

namespace GeometricAreaLibrary.Tests.Figure;

public class CircleTest
{
    [Fact]
    public void Get_Calculate_Area_With_Positive_Radius_Returns_Area()
    {
        var circle = new Circle(2);
        var result = circle.CalculateArea();
        Assert.Equal(12.6, result);
    }

    [Fact]
    public void Get_Calculate_Area_With_Negative_Radius_Return_Area()
    {
        var circle = new Circle(-1);
        var result = circle.CalculateArea();
        Assert.Equal(3.1, result);
    }

    [Fact]
    public void Get_Calculate_Area_With_Zero_Radius_Return_Area()
    {
        var circle = new Circle(0);
        var result = circle.CalculateArea();
        Assert.Equal(0, result);
    }
}