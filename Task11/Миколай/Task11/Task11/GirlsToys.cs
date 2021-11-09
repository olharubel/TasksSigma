using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class GirlsToys: ChildrenToy
    {

        public GirlsToys(string name)
        {
            Name = name;
        }

        public override string GetGender()
        {
            return "For girls";
        }
    }
}
