﻿using CreateShapes.Entities.Enums;

namespace CreateShapes.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) 
            : base(color)
        {
            Width = width;
            Height = height;
        }


        public override double Area()
        {
            return Width * Height;
        }
    }
}
