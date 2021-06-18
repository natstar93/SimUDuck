using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SimUDuck!");

            Duck mal = new MallardDuck();
            Duck mandarin = new MandarinDuck();
            Duck rubber = new RubberDuck();
            Duck decoy = new DecoyDuck();

            Console.WriteLine("\n**MallardDuck**");

            Console.WriteLine(mal.Swim());
            Console.WriteLine(mal.Display());
            mal.performFly();
            mal.performQuack();

            Console.WriteLine("\n**MandarinDuck**");

            Console.WriteLine(mandarin.Swim());
            Console.WriteLine(mandarin.Display());
            mandarin.performFly();
            mandarin.performQuack();

            Console.WriteLine("\n**RubberDuck**");

            Console.WriteLine(rubber.Swim());
            Console.WriteLine(rubber.Display());
            rubber.performFly();
            rubber.performQuack();

            Console.WriteLine("\n**DecoyDuck**");

            Console.WriteLine(decoy.Swim());
            Console.WriteLine(decoy.Display());
            decoy.performFly();
            decoy.performQuack();
        }
    }
}
