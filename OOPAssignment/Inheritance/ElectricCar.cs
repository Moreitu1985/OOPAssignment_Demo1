using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Inheritance
    //We seal to restrict inheritence ,Not permitting any class to continue inheritting .
{
    public sealed class  ElectricCar : Car
    {
        public double BatteryRangeKm { get; set; }

        public ElectricCar(string make, string model, int year, int doorcount,double batteryrangekm) : base(make, model, year, doorcount)
        {
            BatteryRangeKm = batteryrangekm;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} || Battery in KM :{BatteryRangeKm} ";
        }
    }
}
