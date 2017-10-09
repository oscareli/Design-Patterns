using System;

namespace Strategy
{
    public class RedHeadDuck : IDuck
    {
        public RedHeadDuck()
        {
            this.Display();

            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I´m a real RedHead Duck");
        }
    }
}