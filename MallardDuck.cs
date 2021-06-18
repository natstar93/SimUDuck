using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new Quack())
        { 
            // if you put something here it will overwrite base class!
        }
        public override string Display()
        {
            return "I am green";
            
        }
    }
}
