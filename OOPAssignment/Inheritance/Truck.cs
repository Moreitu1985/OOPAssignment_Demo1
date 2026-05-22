using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Inheritance
{
    public class Truck : Vehicle
    {
        public double PayloadTons {  get; set; }
        public Truck(string make, string model, int year,double payloadtons) : base(make, model, year)
        {
            PayloadTons = payloadtons;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}- PayloadTons{PayloadTons} ";
        }
    }
}
