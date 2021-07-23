using System;

namespace CSharpDU
{
    public interface IShape { }
    public record Circle(int Radius) : IShape;
    public record Rectangle(int Height, int Length) : IShape;
    public record Square(int Side) : IShape;
    public record Triangle(int Base, int Height) : IShape;

    public class Shape
    {
        public static double CalculateArea(IShape shape)
        {
            var result = shape switch
            {
                Circle c => c.Radius * Math.PI,
                Square s => s.Side * s.Side,
                Rectangle r => r.Height * r.Length,
                Triangle t => t.Base * t.Height * 0.5,
                _ => throw new NotImplementedException()
            };

            return result;
        }
    }
}
