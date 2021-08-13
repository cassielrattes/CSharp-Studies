
using CreateShapes.Entities.Enums;
using System;

namespace CreateShapes.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) 
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
