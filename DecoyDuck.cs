using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWay(), new MuteQuack())
        {

        }

        public override string Display()
        {
            return "Looks wooden";
        }

        
    }
}
