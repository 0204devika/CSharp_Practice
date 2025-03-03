using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Person
    {
        public virtual void Getdetails()
        {

        }
    }
    class Teacher : Person
    {
        public int t_id;
        public string? t_name;
        public override void Getdetails()
        {
            Console.WriteLine("Teacher Name: " + t_name + "Teacher id: " + t_id);
        }
    }
    class Stu : Person
    {
        public int s_id;
        public string? s_name;
        public override void Getdetails()
        {
            Console.WriteLine("Student Name: " + s_name + "Student id: " + s_id);
        }

    }
}
