﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    abstract class ChildrenToy
    {
        public string Name
        {
            get;
            protected set;
        }

        public abstract string GetGender();
    }
}
