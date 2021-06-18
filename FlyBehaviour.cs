using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    interface FlyBehaviour
    {
        void fly();
    }

    class FlyWithWings : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Fly fly");
        }
    }

    class FlyNoWay : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Goin' nowhere");
        }
    }
}
