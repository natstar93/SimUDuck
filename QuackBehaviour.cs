using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    interface QuackBehaviour
    {
        void quack();
    }

    class Quack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack quack");
        }
    }

    class Squeak : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeeeak");
        }
    }

    class MuteQuack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("...");
        }
    }
}
