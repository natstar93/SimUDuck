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

            Console.WriteLine(mal.Quack());
            Console.WriteLine(mal.Swim());
            Console.WriteLine(mal.Display());

            Console.WriteLine("****");

            Console.WriteLine(mandarin.Quack());
            Console.WriteLine(mandarin.Swim());
            Console.WriteLine(mandarin.Display());

        }
    }
}
