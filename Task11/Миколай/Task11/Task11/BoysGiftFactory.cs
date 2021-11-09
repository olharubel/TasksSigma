using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class BoysGiftFactory: ToyFactory
    {
        public override ChildrenToy CreateToys(string name)
        {
            return new BoysToys(name);
        }
    }
}
