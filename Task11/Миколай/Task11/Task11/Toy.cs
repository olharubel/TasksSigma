using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Toy
    {
        private ChildrenToy toy;

        public string Name { get; private set; }

        public Toy(ToyFactory factory, string name)
        {
            toy = factory.CreateToys(name);
            Name = name;
        }

        public string GetGender()
        {
            return toy.GetGender();
        }
    }
}
