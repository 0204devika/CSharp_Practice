using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Sum of two numbers: " + a + b);
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine("Sum of three numbers: " + a + b + c);
        }
        public void Add(double a,double b)
        {
            Console.WriteLine("Sum of two double numbers: " + a + b);
        }
    }
}
