using System.Text;
using GeometryApp;

namespace GeometricAreaLibrary.Tests;

public class MainAppTest
{
    [Fact]
    public void Get_Circle_Area_With_Valid_Input_Return_Result()
    {
        var input = new StringReader("2\n");
        var output = new StringBuilder();
        var consoleOutput = new StringWriter(output);
        Console.SetIn(input);
        Console.SetOut(consoleOutput);

        var app = new MainApp();
        app.CircleArea();

        var result = output.ToString().Trim();
        Assert.Contains("Area of a circle: 12,6", result);
    }
    
    [Fact]
    public void Get_Triangle_Area_With_Valid_Input_Return_Result()
    {
        var input = new StringReader("1\n2\n4\n2\n");
        var output = new StringBuilder();
        var consoleOutput = new StringWriter(output);
        Console.SetIn(input);
        Console.SetOut(consoleOutput);

        var app = new MainApp();
        app.TriangleArea();

        var result = output.ToString().Trim();
        Assert.Contains("Area of a triangle: 1", result);
    }
}