using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    abstract class VehicleFactory
    {
        public abstract string Vehicletype();
    }
    class Car_1 : VehicleFactory
    {
        public override string Vehicletype()
        {
            return "Vehicle is : Car";
        }
    }
    class Bike_1 : VehicleFactory
    {
        public override string Vehicletype()
        {
            return "Vehicle is : Bike";
        }
    }
    class TypeOfVehicle
    {
        public static VehicleFactory Typev(string typeofveh)
        {
            switch (typeofveh.ToLower())
            {
                case "car":
                    return new Car_1();
                case "bike":
                    return new Bike_1();
                default:
                    throw new ArgumentException("Unknown vehicle type");
            }
        }
    }
}
