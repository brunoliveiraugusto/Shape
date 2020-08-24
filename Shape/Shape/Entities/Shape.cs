﻿using Shape.Entities.Enums;

namespace Shape.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) { }

        public abstract double Area();
    }
}
