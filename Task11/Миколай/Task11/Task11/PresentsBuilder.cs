using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    abstract class PresentsBuilder
    {
        public Present Present { get; private set; }

        public void CreatePresent()
        {
            Present = new Present();
        }

        public abstract void SetToy();
        public abstract void SetWish(string wish);
        public abstract void SetEatableGift(string name);
    }
}
