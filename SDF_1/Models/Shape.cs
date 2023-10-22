namespace SDF_1.Models;

public abstract class Shape
{
    public Color Color { get; set; }
    public bool Filled { get; set; }

    public Shape(Color color, bool filled)
    {
        Color = color;
        Filled = filled;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $" Color: \t\t{Color.Name}\n Filled: \t\t{Filled}\n";
    }
}

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
                _radius = value;
            else
                throw new ArgumentException("Radius must be greater than 0");
        }
    }

    public Circle(Color color, bool filled, double radius) 
        : base(color, filled)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI,2) * Math.Pow(Radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.Round(Math.PI, 2) * Radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Radius: \t\t{Radius}\n Area: \t\t{GetArea()}\n Perimeter: \t{GetPerimeter()}";
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set
        {
            if (value > 0)
                _width = value;
            else
                throw new ArgumentException("Width must be greater than 0");
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value > 0)
                _height = value;
            else
                throw new ArgumentException("Height must be greater than 0");
        }
    }

    public Rectangle(Color color, bool filled, double width, double height) 
        : base(color, filled)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public override string ToString()
    {
        return $"{base.ToString()} Width: \t\t{Width}\n Height: \t\t{Height}\n Area: \t\t{GetArea()}\n Perimeter: \t{GetPerimeter()}";
    }
}


public class Square : Rectangle
{
    public Square(Color color, bool filled, double side) 
        : base(color, filled, side, side)
    {
    }
}
