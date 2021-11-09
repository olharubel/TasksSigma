using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class BoysToys: ChildrenToy
    {
        public BoysToys(string name)
        {
            Name = name;
        }

        public override string GetGender()
        {
            return "For boys";
        }
    }
}
