using CreateShapes.Entities.Enums;

namespace CreateShapes.Entities
{
   abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
