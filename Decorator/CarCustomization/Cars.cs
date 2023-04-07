using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomization
{
    abstract public class Vehicle
    {
        protected string vehicleName;
        public string VehicleName { get { return vehicleName; } set { vehicleName = value; } }
        public void Drive()
        {
            Console.WriteLine($"You are driving {vehicleName}");
        }
    }

    public class Sedan : Vehicle
    {
        public Sedan()
        {
            VehicleName = "a Sedan";
        }
    }
    public class Suv : Vehicle
    {
        public Suv()
        {
            VehicleName = "a Suv";
        }
    }
}
