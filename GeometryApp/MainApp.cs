using GeometricAreaLibrary.Figure;

namespace GeometryApp;

public class MainApp
{
    public void Start()
    {
        Console.WriteLine("Welcome new user");

        while (true)
        {
            Console.WriteLine("Choose the following actions:" +
                              "\n1-Area of a circle" +
                              "\n2-Area of a triangle" +
                              "\n3-Exit");
            var answer = Console.ReadLine();

            if (!int.TryParse(answer, out var choose) || choose < 1 || choose > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (choose == 3)
                break;

            switch (choose)
            {
                case 1:
                    CircleArea();
                    break;
                case 2:
                    TriangleArea();
                    break;
            }
        }
    }

    private void CircleArea()
    {
        Console.WriteLine("Enter the radius of the circle");
        if (!double.TryParse(Console.ReadLine(), out var circleRadius) || circleRadius <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
            return;
        }

        var circle = new Circle(circleRadius);
        var answer = circle.CalculateArea();
        Console.WriteLine($"Area of a circle: {answer}");
    }

    private void TriangleArea()
    {
        Console.WriteLine("Enter first side");
        if (!double.TryParse(Console.ReadLine(), out var aSideTriangle) || aSideTriangle <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
            return;
        }

        Console.WriteLine("Enter second side");
        if (!double.TryParse(Console.ReadLine(), out var bSideTriangle) || bSideTriangle <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
            return;
        }

        Console.WriteLine("Enter third side");
        if (!double.TryParse(Console.ReadLine(), out var cSideTriangle) || cSideTriangle <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
            return;
        }

        Console.WriteLine("Enter the radius of the triangle");
        if (!double.TryParse(Console.ReadLine(), out var triangleRadius) || triangleRadius <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than zero.");
            return;
        }

        var triangle = new Triangle(aSideTriangle, bSideTriangle, cSideTriangle, triangleRadius);
        var answer = triangle.CalculateArea();
        var isRightTriangle = triangle.IsRightTriangle();

        Console.WriteLine(isRightTriangle ? "Triangle is rectangular" : "Triangle is not rectangular");
        Console.WriteLine($"Area of a triangle: {answer}");
    }
}