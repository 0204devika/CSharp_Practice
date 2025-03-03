using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    public class Manager
    {
        public string Name;

        public Manager(string name)
        {
            Name = name;
        }

        public Manager ShallowCopy()
        {
            return (Manager)this.MemberwiseClone();
        }

        public Manager DeepCopy()
        {
            return new Manager(Name);
        }
    }
}
