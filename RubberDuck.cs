using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new Squeak())
        {

        }
        
        public override string Display()
        {
            return "Looks rubbery";
        }
    }
}
