using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class AllChildrenPresentBuilder: PresentsBuilder
    {
        public string Gender { get; private set; }
        public AllChildrenPresentBuilder(string gender)
        {
            Gender = gender;
        }

        public override void SetToy()
        {
            Present.Toy = Storage.GetToy(Gender);

        }

        public override void SetEatableGift(string name)
        {
            Present.EatableGift = Storage.GeGift();
        }

        public override void SetWish(string wish)
        {
            Present.Wish = Storage.GetWish();
        }
    }
}
