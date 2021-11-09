using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class ImpolitePresentBuilder: PresentsBuilder
    {
        public override void SetToy()
        {
            
        }

        public override void SetEatableGift(string name)
        {
            this.Present.EatableGift = new EatableGift("Your present this year is birch!");
        }

        public override void SetWish(string wish)
        {
            this.Present.Wish = new Wish("I wish you to be polite next year!");
        }
    }
}
