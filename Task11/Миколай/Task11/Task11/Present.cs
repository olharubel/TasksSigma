using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Present
    {
        public Toy Toy { get; set; }

        public Wish Wish { get; set; }

        public EatableGift EatableGift { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Toy != null)
                sb.Append(Toy.Name + "\n");
            if (Wish != null)
                sb.Append(Wish.Message + "\n");
            if (EatableGift != null)
                sb.Append(EatableGift.Name + "\n");
            return sb.ToString();
            

        }
    }
}
