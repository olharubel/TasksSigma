using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class PolitePresentBuilder : PresentsBuilder
    {
        public string Gender { get;  private set; }
        public PolitePresentBuilder(string gender)
        {
            Gender = gender;
        }

        public override void SetToy()
        {
            Present.Toy = Storage.GetRandomToy(Gender);
        }

        public override void SetEatableGift(string name)
        {
            Present.EatableGift = Storage.GetRandomEatableGift();
        }

        public override void SetWish(string wish)
        {
            Present.Wish = Storage.GetRandomWish();
        }
    }
}
