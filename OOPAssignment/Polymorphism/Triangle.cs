using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Polymorphism
{
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * BaseLength * Height;
        }

        // Simplified example
        public override double Perimeter()
        {
            return BaseLength * 3;
        }
    }
}
