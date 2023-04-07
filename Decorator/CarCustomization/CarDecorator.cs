using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomization
{
    public abstract class VehicleDecorator:Vehicle
    {
        protected Vehicle vehicle;
        public VehicleDecorator(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public abstract void Customize();
    }

    public class SedanDecorator<T>: VehicleDecorator where T: Sedan
    {
        public SedanDecorator(Vehicle vehicle) : base(vehicle) { }
        public override void Customize()
        {
            Console.WriteLine("Customizing Sedan");
        }
    }
    public class SuvDecorator<T> : VehicleDecorator where T : Suv
    {
        public SuvDecorator(Vehicle vehicle) : base(vehicle) { }
        public override void Customize()
        {
            Console.WriteLine("Customizing Suv");
        }
    }
}
