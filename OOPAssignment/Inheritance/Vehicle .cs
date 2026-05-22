using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Inheritance
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        //Virtual for allowing overriding
        public virtual string GetDescription()
        {
            return $"YEAR:{Year} Manufacture :{Make} Model : {Model}";
        }
    }
}
