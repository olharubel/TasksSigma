using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    abstract class ToyFactory
    {
        public abstract ChildrenToy CreateToys(string name);
    }
}
