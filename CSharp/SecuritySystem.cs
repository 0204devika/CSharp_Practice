using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    sealed class SecuritySystem
    {
        public SecuritySystem()
        {
            Console.WriteLine("this is a sealed class");
        }
        public void display()
        {
            Console.WriteLine("hwllo, this is sealed class security system");
        }
    }
//    class child : SecuritySystem
//{
//    public child()
//    {
//        Console.WriteLine("cannot inherit from sealed class");
//    }
}

