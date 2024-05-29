using GeometricAreaLibrary.Figure;

namespace GeometricAreaLibrary.Tests.Figure;

public class TriangleTest
{
    [Fact]
    public void Get_Calculate_Area_With_Positive_Radius_And_Correct_Three_Sides_Returns_Area()
    {
        var triangle = new Triangle(1, 2, 4, 2);
        var result = triangle.CalculateArea();
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Positive_Radius_And_Correct_Two_Sides_Returns_Area()
    {
        var triangle = new Triangle(1, 2, 0, 2);
        var result = triangle.CalculateArea();
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Positive_Radius_And_Correct_One_Sides_Returns_Area()
    {
        var triangle = new Triangle(1, 0, 0, 2);
        var result = triangle.CalculateArea();
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Positive_Radius_And_Correct_Zero_Sides_Returns_Area()
    {
        var triangle = new Triangle(0, 0, 0, 2);
        var result = triangle.CalculateArea();
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Zero_Radius_And_Correct_Zero_Sides_Returns_Area()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0, 0));
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Zero_Radius_And_Correct_Three_Sides_Returns_Area()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4, 0));
    }
    
    [Fact]
    public void Get_Calculate_Area_With_Negative_Radius_And_Correct_Three_Sides_Returns_Area()
    {
        var triangle = new Triangle(1, 2, 4, -2);
        var result = triangle.CalculateArea();
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Get_Is_Right_Triangle_With_Right_Triangle_Sides_Returns_True()
    {
        var triangle = new Triangle(3, 4, 5, 2);
        var result = triangle.IsRightTriangle();
        Assert.True(result);
    }
    
    [Fact]
    public void Get_Is_Right_Triangle_With_Right_Triangle_Sides_Returns_False()
    {
        var triangle = new Triangle(3, 3, 5, 2);
        var result = triangle.IsRightTriangle();
        Assert.False(result);
    }
}