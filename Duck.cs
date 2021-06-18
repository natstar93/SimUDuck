using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    abstract class Duck
    {
        public FlyBehaviour FlyBehaviour;
        public QuackBehaviour QuackBehaviour;

        // need constructor. constructor/destructor are the only methods that don't return anything
        public Duck(FlyBehaviour flyBehaviour, QuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour; // (or _flyBehaviour, or this.flyBehaviour)
            QuackBehaviour = quackBehaviour;
        }


        public void performFly()
        {
            FlyBehaviour.fly();
        }

        public void performQuack()
        {
            QuackBehaviour.quack();
        }

        public string Swim ()
        {
            return "Swim swim";
        }

        public abstract string Display();

    }
}
