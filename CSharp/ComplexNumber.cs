using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public ComplexNumber(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber c1,ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public override string ToString()
        {
            return $"{Real}+{Imaginary}i";
        }
    }
}
