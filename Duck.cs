using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    abstract class Duck
    {
        public string Quack ()
        {
            return "Quack";
        }

        public string Swim ()
        {
            return "Swim swim";
        }
        public abstract string Display();

    }
}
