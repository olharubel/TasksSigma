using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Devil
    {
            public Present CreatePresent(PresentsBuilder builder)
            {
                builder.CreatePresent();
                builder.SetEatableGift("Mango");
                builder.SetWish("Be happy");
                return builder.Present;
            }
        
    }
}
