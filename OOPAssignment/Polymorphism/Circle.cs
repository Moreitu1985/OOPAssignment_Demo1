using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Polymorphism
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        const double PI = 3.14;
        public Circle(double radius) {
            Radius = radius;
        }

        public override double Area()
        {
           return Radius*2 *PI;
        }

       

        public override double Perimeter()
        {
            return 2 * (PI) * Radius;
        }
    }
}
