using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Inheritance
{
    public class Car : Vehicle

    {

        public int DoorCount;

        public Car(string make, string model, int year,int doorcount) : base(make, model, year)
        {
            DoorCount=doorcount;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()} || Doors: {DoorCount}";
        }
    }
}

