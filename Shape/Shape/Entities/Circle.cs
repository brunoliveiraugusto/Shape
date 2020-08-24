using Shape.Entities.Enums;
using System;

namespace Shape.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
