using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    public interface IPrintable
    {
        void Print();
    }
    public interface Iserializable
    {
        void SaveToFile(string f_name);
    }
    public class Report : IPrintable, Iserializable
    {
        private string info;
        public Report(string info)
        {
            this.info = info;
        }
        public void Print()
        {
            Console.WriteLine("Information in file: " + info);
        }
        public void SaveToFile(string f_name)
        {
            File.WriteAllText(f_name, info);
            Console.WriteLine("Saved: " + f_name);
        }
    }
}
