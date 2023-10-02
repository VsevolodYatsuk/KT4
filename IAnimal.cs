using System;

// IAnimal
public interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}

// Dog
public class Dog : IAnimal
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} says Woof!");
    }
}

// Cat
public class Cat : IAnimal
{
    public string Name { get; set; }

    public Cat(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} says Meow!");
    }
}

// IShape
public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

// Circle
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }

    public double Perimeter
    {
        get { return 2 * Math.PI * Radius; }
    }
}

// Rectangle
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area
    {
        get { return Width * Height; }
    }

    public double Perimeter
    {
        get { return 2 * (Width + Height); }
    }
}

// Triangle
public class Triangle : IShape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double Area
    {
        get
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }

    public double Perimeter
    {
        get { return Side1 + Side2 + Side3; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = new Dog("Buddy");
        IAnimal cat = new Cat("Whiskers");

        dog.MakeSound();
        cat.MakeSound();

        IShape circle = new Circle(5.0);
        IShape rectangle = new Rectangle(4.0, 6.0);
        IShape triangle = new Triangle(3.0, 4.0, 5.0);

        Console.WriteLine($"Circle Area: {circle.Area:F2}, Perimeter: {circle.Perimeter:F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area:F2}, Perimeter: {rectangle.Perimeter:F2}");
        Console.WriteLine($"Triangle Area: {triangle.Area:F2}, Perimeter: {triangle.Perimeter:F2}");

        Console.ReadLine();
    }
}
