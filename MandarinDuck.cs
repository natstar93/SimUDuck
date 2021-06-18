﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class MandarinDuck : Duck
    {
        public MandarinDuck() : base(new FlyWithWings(), new Quack())
        {

        }

        public override string Display()
        {
            return "I am very colourful";
        }

    }
}
