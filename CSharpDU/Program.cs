using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDU;

List<IShape> shapes = new()
{
    new Circle(5),
    new Square(5),
    new Rectangle(5, 5),
    new Triangle(5, 5),
    new Circle(10),
    new Square(10),
    new Rectangle(10, 5),
    new Triangle(5, 10),
};

List<double> areas = shapes.Select(Shape.CalculateArea).ToList();

foreach (var area in areas)
{
    Console.WriteLine(area);
}
