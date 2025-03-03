using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    public abstract class Shape
    {
        public virtual void CalArea()
        {

        }

    }
    public class Circle : Shape
    {
        public int radius;
        public override void CalArea()
        {
            Console.WriteLine("Area of Circle: " + 3.14 * radius*radius);
        }
    }
    public class Rectangle : Shape
    {
        public int length;
        public int breadth;
        public override void CalArea()
        {
            Console.WriteLine("Area of Circle: " + length*breadth);
        }
    }

}
