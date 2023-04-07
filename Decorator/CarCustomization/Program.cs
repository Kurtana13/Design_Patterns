using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCustomization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Sedan();
            Vehicle car2= new Suv();
            VehicleDecorator sedanDec = new SedanDecorator<Sedan>(car1);
            VehicleDecorator suvDec = new SuvDecorator<Suv>(car2);

            sedanDec.Customize();
            suvDec.Customize();

            Console.ReadLine();
        }
    }
}
