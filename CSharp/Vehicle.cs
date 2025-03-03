using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is Moving");
        }
    }
    class Bike: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is Moving");
        }
    }
}
