using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class GirlsGiftFactory: ToyFactory
    {
        public override ChildrenToy CreateToys(string name)
        {
            return new GirlsToys(name);
        }
    }
}
