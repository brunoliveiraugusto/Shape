using System;
using System.Collections.Generic;
using Shape.Entities;
using Shape.Entities.Enums;
using System.Globalization;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape.Entities.Shape> shapes = new List<Shape.Entities.Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberShapes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char typeShape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(typeShape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("SHAPE AREAS:");

            foreach(Shape.Entities.Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
