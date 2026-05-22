using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Polymorphism
{
    public abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();

        public virtual string Describe()
        {
            //round the area into 2 decimal places
            return $"{GetType().Name} Area: {Math.Round(Area(), 2)}";
        }
    }
}
