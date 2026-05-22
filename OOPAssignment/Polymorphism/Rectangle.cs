using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Polymorphism
{
    public class Rectangle : Shape
    {
        public double Length;
        public double Width;
        public Rectangle(double length,double width) { 

        Length= length;
        Width= width;
        
        }

        public override double Area()
        {
            return Length*Width;
        }

        public override double Perimeter()
        {
           return 2 * Length + 2 * Width;    
        }
    }
}
