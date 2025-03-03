using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Student
    {
        private string Name;
        private int RollNo;
        public void addstudent(string Name)
        {
            if (Name == "")
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
        public void addrollno(int RollNo)
        {
            if (RollNo < 0)
            {
                Console.WriteLine("Roll number cannot be negative");
            }
        }


    }
}
